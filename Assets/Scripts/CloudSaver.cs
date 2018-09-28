using GooglePlayGames;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class SaveData
{
    
    public int playerMoney;
    public int playerScore;

    // Convert class instance to byte array
    public static byte[] ToBytes(SaveData data)
    {

        var formatter = new BinaryFormatter();

        using (var stream = new MemoryStream())
        {

            formatter.Serialize(stream, data);
            return stream.ToArray();
        }
    }

    // Convert byte array to class instance
    public static SaveData FromBytes(byte[] data)
    {

        using (var stream = new MemoryStream())
        {

            var formatter = new BinaryFormatter();
            stream.Write(data, 0, data.Length);
            stream.Seek(0, SeekOrigin.Begin);

            SaveData block = (SaveData)formatter.Deserialize(stream);
            return block;
        }
    }
}

public class CloudSaver : MonoBehaviour
{
    public Text scoreTextS;
    public Text moneyTextS;
    // Variables
    bool userSignedIn = false;
    ISavedGameMetadata currentGame = null;

    public static CloudSaver singleton;

    // Use this for initialization
    void Start()
    {
        InitPlayServices();
        singleton = this;
        


        scoreTextS.text = "" + PlayerPrefs.GetInt("best");
        moneyTextS.text = "" + PlayerPrefs.GetInt("bestMoney");
    }

    // Initialize google play services
    void InitPlayServices()
    {

        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()
            .EnableSavedGames()
            .Build();

        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
    }

    // Sign in the user
    public void SignInUser()
    {

        if (!userSignedIn)
            PlayGamesPlatform.Instance.Authenticate(CallbackSignInUser);
    }

    // The sign in callback
    void CallbackSignInUser(bool success)
    {

        if (success)
            userSignedIn = true;
    }

    // Read the save game
    void ReadSaveGame(string filename, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
    {

        // Check if signed in
        if (userSignedIn)
        {

            ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;

            savedGameClient.OpenWithAutomaticConflictResolution(filename,
                DataSource.ReadCacheOrNetwork,
                ConflictResolutionStrategy.UseLongestPlaytime,
                callback);
        }
    }

    // Write the save game
    void WriteSaveGame(ISavedGameMetadata game, byte[] savedData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback)
    {

        // Check if signed in
        if (userSignedIn)
        {

            SavedGameMetadataUpdate updatedMetadata = new SavedGameMetadataUpdate.Builder()
                .WithUpdatedPlayedTime(TimeSpan.FromMinutes(game.TotalTimePlayed.Minutes + 1))
                .WithUpdatedDescription("Saved at: " + DateTime.Now)
                .Build();

            ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
            savedGameClient.CommitUpdate(game, updatedMetadata, savedData, callback);
        }
    }

    // Save the game
    public void SaveGame()
    {

        // Check if signed in
        if (userSignedIn)
        {

            // Save game callback
            Action<SavedGameRequestStatus, ISavedGameMetadata> writeCallback =
                (SavedGameRequestStatus status, ISavedGameMetadata game) => {

                };

            // Read binary callback
            Action<SavedGameRequestStatus, byte[]> readBinaryCallback =
                (SavedGameRequestStatus status, byte[] data) => {

                };

            // Read game callback
            Action<SavedGameRequestStatus, ISavedGameMetadata> readCallback =
                (SavedGameRequestStatus status, ISavedGameMetadata game) => {

                    // Check if read was successful
                    if (status == SavedGameRequestStatus.Success)
                    {

                        currentGame = game;
                        PlayGamesPlatform.Instance.SavedGame.ReadBinaryData(game, readBinaryCallback);
                    }
                };

            // Create new save data
            SaveData saveData = new SaveData
            {

                // These values are hard coded for the purpose of this tutorial.
                // Normally, you would replace these values with whatever you want to save.
                playerMoney = PlayerPrefs.GetInt("bestMoney"),
                playerScore = PlayerPrefs.GetInt("best")
            };

            // Replace "MySaveGame" with whatever you would like to save file to be called
            ReadSaveGame("MySaveGame", readCallback);
            WriteSaveGame(currentGame, SaveData.ToBytes(saveData), writeCallback);
        }
    }

    // Load the game
    public void LoadGame()
    {

        // Check if signed in
        if (userSignedIn)
        {

            // Read binary callback
            Action<SavedGameRequestStatus, byte[]> readBinaryCallback =
                (SavedGameRequestStatus status, byte[] data) => {

                    // Check if read was successful
                    if (status == SavedGameRequestStatus.Success)
                    {

                        // Load game data
                        try
                        {

                            SaveData saveData = SaveData.FromBytes(data);

                            // We are displaying these values for the purpose of the tutorial.
                            // Normally you would set the values here.
                            Debug.Log("Player health = " + saveData.playerMoney);
                            Debug.Log("Player score = " + saveData.playerScore);
                        }

                        catch (Exception e)
                        {

                            Debug.LogError("Failed to read binary data: " + e.ToString());
                        }
                    }
                };

            // Read game callback
            Action<SavedGameRequestStatus, ISavedGameMetadata> readCallback =
                (SavedGameRequestStatus status, ISavedGameMetadata game) => {

                    // Check if read was successful
                    if (status == SavedGameRequestStatus.Success)
                    {

                        currentGame = game;
                        PlayGamesPlatform.Instance.SavedGame.ReadBinaryData(game, readBinaryCallback);
                    }
                };

            // Replace "MySaveGame" with whatever you would like to save file to be called
            ReadSaveGame("MySaveGame", readCallback);
        }
    }

    public void saveGame()
    {
        CloudSaver.singleton.SaveGame();
    }

    public void loadGame()
    {
        CloudSaver.singleton.LoadGame();
    }
}
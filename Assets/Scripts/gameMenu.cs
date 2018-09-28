using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
//using GooglePlayGames.BasicApi.SavedGame;
using System;
using System.Collections;
using UnityEngine.SocialPlatforms;
using GoogleMobileAds.Api;

public class gameMenu : MonoBehaviour {
    
	public Image[] faqPause;
    public int HighestWaveCompleted { set; get; }

    public float LastSave { set; get; }
    public float PlaytimeSinceSave { set; get; }
    public float TotalPlaytime { get { return (Time.time - LastSave) + PlaytimeSinceSave; } }

	public GameObject sound, mute;
    int bestS, bestMoneyS;
    public Text scoreTextS;
    public Text moneyTextS;

    private string leaderboard = "CgkI5rrPkZgPEAIQAA";

	private const string gameBonus = "ca-app-pub-4550678827778919/5643227981";
	private InterstitialAd ad;

	public Image[] closeDoor;
	public Image[] plus50;
	public Image[] plusButton;


    void Start()
    {
		ad = new InterstitialAd (gameBonus);
		AdRequest request = new AdRequest.Builder ().Build ();
		//AdRequest request = new AdRequest.Builder ().AddTestDevice (AdRequest.TestDeviceSimulator).AddTestDevice ("3172DDD060FADA61").Build ();
		ad.LoadAd (request);
		if (PlayerPrefs.GetString("Music") == "no")
		{
			sound.SetActive(true);
			mute.SetActive(true);
		}
		else
		{
			sound.SetActive(true);
			mute.SetActive(false);
		}

        //PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().EnableSavedGames().Build();
        //PlayGamesPlatform.InitializeInstance(config);
        //PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate((bool success) => { });
        


        bestS = PlayerPrefs.GetInt("best");
        scoreTextS.text = "" + bestS;
        bestMoneyS = PlayerPrefs.GetInt("bestMoney");
        moneyTextS.text = "" + bestMoneyS;
    }

	void Update() 
	{
		if (PlayerPrefs.GetString("Music") == "no")
			GetComponent<AudioSource>().mute = true;
		else if (PlayerPrefs.GetString("Music") == "yes")
			GetComponent<AudioSource>().mute = false;
	}

	public void audioBtn()
	{
		if (PlayerPrefs.GetString("Music") != "no")
			GameObject.Find("gameMenu").GetComponent<AudioSource>().Play();
		if(PlayerPrefs.GetString("Music") != "no")
		{
			PlayerPrefs.SetString("Music", "no");
			sound.SetActive(true);
			mute.SetActive(true);
		}else
		{
			PlayerPrefs.SetString("Music", "yes");
			sound.SetActive(true);
			mute.SetActive(false);
		}
	}
/*
    private bool isSaving;
    public void LoadCloud()
    {
        isSaving = false;
        ((PlayGamesPlatform)Social.Active).SavedGame.OpenWithAutomaticConflictResolution
                ("SpaceEscape", GooglePlayGames.BasicApi.DataSource.ReadCacheOrNetwork,
                ConflictResolutionStrategy.UseLongestPlaytime, SavedGameOpened);
    }
    public void SaveCloud()
    {
        if (Social.localUser.authenticated)
        {
            isSaving = true;
            ((PlayGamesPlatform)Social.Active).SavedGame.OpenWithAutomaticConflictResolution
                ("SpaceEscape", GooglePlayGames.BasicApi.DataSource.ReadCacheOrNetwork,
                ConflictResolutionStrategy.UseLongestPlaytime, SavedGameOpened);
        }
        else
        {

        }
    }
    public void SavedGameOpened(SavedGameRequestStatus status, ISavedGameMetadata game)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            if (isSaving)
            {
                byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(GetSaveString());
                TimeSpan playedTime = TimeSpan.FromSeconds(TotalPlaytime);
                SavedGameMetadataUpdate.Builder builder = new SavedGameMetadataUpdate.Builder().WithUpdatedPlayedTime(playedTime).WithUpdatedDescription("Saved Game at " + DateTime.Now);

                SavedGameMetadataUpdate update = builder.Build();
                ((PlayGamesPlatform)Social.Active).SavedGame.CommitUpdate(game, update, data, SavedGameWritten);
            }
            else
            {
                ((PlayGamesPlatform)Social.Active).SavedGame.ReadBinaryData(game, SavedGameLoaded);
            }
        }
        else
        {

        }
    }
    public void SavedGameLoaded(SavedGameRequestStatus status, byte[] data)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            LoadFromString(System.Text.ASCIIEncoding.ASCII.GetString(data));
        }
        else
        {
            Debug.Log("Error reading game: " + status);
        }
    }
    public void SavedGameWritten(SavedGameRequestStatus status, ISavedGameMetadata game)
    {
        Debug.Log(status);
    }
    private void LoadFromString(string saveData)
    {
        if (saveData == "")
            return;

        string[] data = saveData.Split('|');

        string[] misc = data[0].Split('%');
        PlaytimeSinceSave = float.Parse(misc[0]);
        HighestWaveCompleted = int.Parse(misc[1]);

        string[] stats = data[1].Split('%');
        bestS = int.Parse(misc[0]);
        bestMoneyS = int.Parse(misc[1]);
    }
    private string GetSaveString()
    {
        string saveData = "";

        saveData += TotalPlaytime.ToString() + '%' + HighestWaveCompleted.ToString() + '|';
        LastSave = Time.time;

        saveData += bestS.ToString();
        saveData += bestMoneyS.ToString();
        return saveData;
    }

*/    
	public void setImageActive50(bool active)
	{
		foreach (Image imgStart in plus50)
		{
			imgStart.gameObject.SetActive(active);

		}
	}

	public void setImageActiveButton(bool active)
	{
		foreach (Image imgStart in plusButton)
		{
			imgStart.gameObject.SetActive(active);

		}
	}

	public void plusMoney(){
		setImageActiveButton (true);
	}
	public void plusMoneyButton(){
			videoReklama ();
			setImageActiveButton (false);
	}

	public void closeReklama(){
		setImageActive50 (false);
	}
	public void closeReklamaButton(){
		setImageActiveButton (false);
	}

    public void videoReklama()
    {
		ad = new InterstitialAd (gameBonus);
		AdRequest request = new AdRequest.Builder ().Build ();
		//AdRequest request = new AdRequest.Builder ().AddTestDevice (AdRequest.TestDeviceSimulator).AddTestDevice ("3172DDD060FADA61").Build ();
		ad.LoadAd (request);
		ad.OnAdLoaded += OnAdLoaded;
	}

	void OnAdLoaded (object sender, System.EventArgs args)
	{
		ad.Show ();
		setImageActive50 (true);
		bestMoneyS += 50;
		moneyTextS.text = "" + bestMoneyS;
		PlayerPrefs.SetInt("bestMoney", bestMoneyS);
	}
    


    public void ToLeaderboard()
    {
        if (Social.localUser.authenticated)
        {
            Social.ReportScore(bestS, leaderboard, (bool success) => { });
            ((PlayGamesPlatform)Social.Active).ShowLeaderboardUI(leaderboard);
            
        }
    }
	public void closefaq()
	{
		setImageActive (false);
	}
	public void faq()
	{
		setImageActive (true);
	}
	public void setImageActive(bool active)
	{
		foreach (Image img in faqPause)
		{
			img.gameObject.SetActive(active);
		}
	}

    public void hangar()
    {
		setImageActiveDoorsClose (true);
    }
	public void setImageActiveDoorsClose(bool active)
	{
		foreach (Image imgStart in closeDoor)
		{
			imgStart.gameObject.SetActive(active);
		}
	}
/*
    public void ReloadSaveData()
    {
        LoadCloud();
    }

    public void OnApplicationQuit()
    {
        SaveCloud();
    }
*/
	public void shareApp(){
		AndroidJavaClass intentClass = new AndroidJavaClass ("android.content.Intent");
		AndroidJavaObject intentObject = new AndroidJavaObject ("android.content.Intent");
		intentObject.Call<AndroidJavaObject> ("setAction", intentClass.GetStatic<string> ("ACTION_SEND"));
		intentObject.Call<AndroidJavaObject> ("setType", "text/plain");
		intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), "SUBJECT");
		intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), "https://play.google.com/store/apps/details?id=com.skdsh.SpaceEscapePixelUniverse");
		AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
		currentActivity.Call ("startActivity", intentObject);

	}
}

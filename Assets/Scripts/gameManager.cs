using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using GooglePlayGames;
using GoogleMobileAds.Api;

public class gameManager : MonoBehaviour {

	public Transform finish1;
    public int money;
    public Text moneyText;
    public Text scoreText;
    public int scores;
    public Image[] GameOverPause;
	public Image[] imagePauseFinish;
    public float timer;
    public float parsek;
    public GameObject pauseBtnOff, pauseBtnOn;
    public GameObject ship, ship1, ship2, ship3, ship4, ship5, ship6, ship7, ship8, ship9, ship10;
    public Image[] imagePause;
    public GameObject camera1;

	public Image[] openDoor;



	private string leaderboard = "CgkI5rrPkZgPEAIQAA";

    void Start () {
		

        money = PlayerPrefs.GetInt("bestMoney");
		scores = 0;
		Time.timeScale = 1;
		setImageActiveDoorsOpen (true);


    }

	void Update () {
		if (PlayerPrefs.GetString("Music") == "no")
			GetComponent<AudioSource>().mute = true;
		else if (PlayerPrefs.GetString("Music") == "yes")
			GetComponent<AudioSource>().mute = false;
		
        if (PlayerPrefs.GetInt("best") < scores)
            PlayerPrefs.SetInt("best", scores);

        if (PlayerPrefs.GetString("Music") == "no")
            GetComponent<AudioSource>().mute = true;

        moneyText.text = "" + money;
        
        timer += parsek * Time.deltaTime;
            scores = (int)timer;
            scoreText.text = "" + scores;
        if (timer > 50f) { parsek = 3f; }
        if (timer > 100f) { parsek = 3.5f; }
		if (timer > 250f) { parsek = 4f; }
		if (timer > 500f) { parsek = 4.5f; }
		if (timer > 750f) { parsek = 5f; }
		if (timer > 1000f) { parsek = 6f; }
		if (timer > 1250f) { parsek = 7f; }
		if (timer > 1500f) { parsek = 8f; }
		if (timer >= 2000f) 
		{ 
			scores = 2000;
			scoreText.GetComponent<Text> ().enabled = false;
			if(PlayerPrefs.GetInt("best") < scores)
				PlayerPrefs.SetInt("best", scores);
			PlayGamesPlatform.Activate();
			Social.ReportScore(scores, leaderboard, (bool success) => { });
			finish1.gameObject.SetActive(true);

			Social.ReportProgress("CgkI5rrPkZgPEAIQBA", 100.0f, (bool success) =>
				{
				});
		}

        int nameShip = PlayerPrefs.GetInt("startShip");
        if (nameShip == 0)
        {
            ship.SetActive(true);
            camera1.GetComponent<cameraController>().enabled = true;

        }

        int nameShip1 = PlayerPrefs.GetInt("startShip");
        if (nameShip1 == 1)
        {
            ship1.SetActive(true);
            camera1.GetComponent<cameraController1>().enabled = true;
        }

        int nameShip2 = PlayerPrefs.GetInt("startShip");
        if (nameShip2 == 2)
        {
            ship2.SetActive(true);
            camera1.GetComponent<cameraController2>().enabled = true;
        }

        int nameShip3 = PlayerPrefs.GetInt("startShip");
        if (nameShip3 == 3)
        {
            ship3.SetActive(true);
            camera1.GetComponent<cameraController3>().enabled = true;
        }

        int nameShip4 = PlayerPrefs.GetInt("startShip");
        if (nameShip4 == 4)
        {
            ship4.SetActive(true);
            camera1.GetComponent<cameraController4>().enabled = true;
        }

        int nameShip5 = PlayerPrefs.GetInt("startShip");
        if (nameShip5 == 5)
        {
            ship5.SetActive(true);
            camera1.GetComponent<cameraController5>().enabled = true;
        }

        int nameShip6 = PlayerPrefs.GetInt("startShip");
        if (nameShip6 == 6)
        {
            ship6.SetActive(true);
            camera1.GetComponent<cameraController6>().enabled = true;
        }

        int nameShip7 = PlayerPrefs.GetInt("startShip");
        if (nameShip7 == 7)
        {
            ship7.SetActive(true);
            camera1.GetComponent<cameraController7>().enabled = true;
        }

        int nameShip8 = PlayerPrefs.GetInt("startShip");
        if (nameShip8 == 8)
        {
            ship8.SetActive(true);
            camera1.GetComponent<cameraController8>().enabled = true;
        }

        int nameShip9 = PlayerPrefs.GetInt("startShip");
        if (nameShip9 == 9)
        {
            ship9.SetActive(true);
            camera1.GetComponent<cameraController9>().enabled = true;
        }

        int nameShip10 = PlayerPrefs.GetInt("startShip");
        if (nameShip10 == 10)
        {
            ship10.SetActive(true);
            camera1.GetComponent<cameraController10>().enabled = true;
        }
    }
                                        // Pause
    public void pauseGame()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pauseBtnOn.SetActive(true);
            setImageActive(true);
			PlayGamesPlatform.Activate();
			Social.ReportScore(scores, leaderboard, (bool success) => { });
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            pauseBtnOn.SetActive(false);
            setImageActive(false);
        }
    }

                                                                //Active panel pause and game over
    public void setImageActive(bool active)
    {
        foreach (Image img in imagePause)
        {
            img.gameObject.SetActive(active);
        }
    }
	public void setImageActiveFinishGame(bool active)
	{
		foreach (Image img in imagePauseFinish)
		{
			img.gameObject.SetActive(active);
		}
	}

    public void setImageActiveGameOver(bool active)
    {
        foreach (Image imgGameOver in GameOverPause)
        {
            imgGameOver.gameObject.SetActive(active);
            if(PlayerPrefs.GetInt("best") < scores)
            PlayerPrefs.SetInt("best", scores);
			PlayGamesPlatform.Activate();
			Social.ReportScore(scores, leaderboard, (bool success) => { });
        }
    }



    //button restart and back
    public void restartGame()
    {
		/*if (clickRestart <= 0) {
			SceneManager.LoadScene ("ReklamaScreen");
		}else*/
		SceneManager.LoadScene("GameScreen");
	}

	public void setImageActiveDoorsOpen(bool active)
	{
		foreach (Image imgStart in openDoor)
		{
			imgStart.gameObject.SetActive(active);
		}
	}
    public void backMenu()
    {
        
        SceneManager.LoadScene("HangarScreen");
    }


}

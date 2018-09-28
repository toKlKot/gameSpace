using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class skdshScript : MonoBehaviour  {

    public float timer;
	public Image[] logoSkdsh;
	public Image[] logoSkdsh1;
	public Image[] logoSkdsh2;

    void Start()
    {
		int objN = Random.Range(0, 3);
		if (objN == 0) {
			setImageActive (true);
			setImageActive1 (false);
			setImageActive2 (false);
		} 
		if(objN == 1){
			setImageActive (false);
			setImageActive1 (true);
			setImageActive2 (false);
		}
		if(objN == 2){
			setImageActive (false);
			setImageActive1 (false);
			setImageActive2 (true);
		}

    }


    void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene("MainScreen");
        }
		if (PlayerPrefs.GetString("Music") == "no")
			GetComponent<AudioSource>().mute = true;
		else if (PlayerPrefs.GetString("Music") == "yes")
			GetComponent<AudioSource>().mute = false;

    }

	public void setImageActive(bool active)
	{
		foreach (Image img in logoSkdsh)
		{
			img.gameObject.SetActive(active);
		}
	}
	public void setImageActive1(bool active)
	{
		foreach (Image img1 in logoSkdsh1)
		{
			img1.gameObject.SetActive(active);
		}
	}
	public void setImageActive2(bool active)
	{
		foreach (Image img2 in logoSkdsh2)
		{
			img2.gameObject.SetActive(active);
		}
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class moveActor : MonoBehaviour
{
	public Slider slide;
    public float timeDead;
	public float timeWin;
    public float speedX;
    //public float speedY;
    public int hp;
    public Text scoreText;

    public Transform boom;
    public Transform shield;
	public Transform finish;

	public int clickRestart = 3;
	private const string gameOverAD = "ca-app-pub-4550678827778919/5361013189";
	private InterstitialAd ad;


    gameManager gm;
    GameObject obj;

    void Start()
    {
		ad = new InterstitialAd (gameOverAD);
		AdRequest request = new AdRequest.Builder ().Build ();
		//AdRequest request = new AdRequest.Builder ().AddTestDevice (AdRequest.TestDeviceSimulator).AddTestDevice ("3172DDD060FADA61").Build ();
		ad.LoadAd (request);

        obj = GameObject.Find("gameManager");
        gm = (gameManager)obj.GetComponent(typeof(gameManager));


		int shieldShip = PlayerPrefs.GetInt("shield100");
		if (shieldShip == 1) 
		{
			hp = 100;
		}
		PlayerPrefs.DeleteKey ("shield100");


		int click = PlayerPrefs.GetInt("clickR");
		if (click <= 0) {
			click = 3;
		}
		clickRestart = click;
		clickRestart = clickRestart - 1;
		PlayerPrefs.SetInt("clickR", clickRestart);

	}



    public void Update()
    {
        if (hp <= -1) { timeDead += 1 * Time.deltaTime;}
        if (timeDead >= 1f) 
		{ 
			
			Time.timeScale = 0; 
			gm.setImageActiveGameOver(true);
		}



		if (gm.scores >= 2000) { timeWin += 1 * Time.deltaTime;}
		if (timeWin >= 2.5f) { Time.timeScale = 0; gm.setImageActiveFinishGame(true); }
		if (timeWin >= 0.5f) {  
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			gameObject.GetComponent<PolygonCollider2D> ().enabled = false;
		}

        Vector3 dir = Vector3.zero;
        dir.x = Input.acceleration.x;
        //dir.y = Input.acceleration.y;



        if (dir.sqrMagnitude > 1)
            dir.Normalize();
        transform.Translate(dir * speedX * Time.deltaTime);
        //transform.Translate(dir * speedY * Time.deltaTime);


        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -8f, 8f);
		pos.y = Mathf.Clamp(pos.y, -4.11f, 2f);
        transform.position = pos;

        //shieldProc = hp;
		slide.value = hp;
        //scoreText.text = shieldProc + " %";

    }


    

    void OnCollisionEnter2D(Collision2D coll)
    {
		if (coll.gameObject.tag == "blockFinish") {
			GameObject finishs = ((Transform)Instantiate (finish, this.transform.position, this.transform.rotation)).gameObject;

			Destroy (finishs, 2f);
		}
        if(coll.gameObject.tag == "man")
        {
			if (gm.money == 0) {
				gm.money = 0;
			} else if (gm.money > 0) {
				gm.money -= (int)Random.Range (1, 4);
				PlayerPrefs.SetInt ("bestMoney", gm.money);
			}
        }
        if(coll.gameObject.tag == "shield25")
        {
            if (hp == 100) { hp += 0; }
            if (hp == 99) { hp += 1; }
            if (hp == 98) { hp += 2; }
            if (hp == 97) { hp += 3; }
            if (hp == 96) { hp += 4; }
            if (hp == 95) { hp += 5; }
            if (hp == 94) { hp += 6; }
            if (hp == 93) { hp += 7; }
            if (hp == 92) { hp += 8; }
            if (hp == 91) { hp += 9; }
            if (hp == 90) { hp += 10; }
            if (hp == 89) { hp += 11; }
            if (hp == 88) { hp += 12; }
            if (hp == 87) { hp += 13; }
            if (hp == 86) { hp += 14; }
            if (hp == 85) { hp += 15; }
            if (hp == 84) { hp += 16; }
            if (hp == 83) { hp += 17; }
            if (hp == 82) { hp += 18; }
            if (hp == 81) { hp += 19; }
            if (hp == 80) { hp += 20; }
            if (hp == 79) { hp += 21; }
            if (hp == 78) { hp += 22; }
            if (hp == 77) { hp += 23; }
            if (hp == 76) { hp += 24; }
            if (hp <= 75) { hp += 25; }
        }
        
		if (coll.gameObject.tag == "coins") {
			gm.money += (int)Random.Range(1,10);
            PlayerPrefs.SetInt("bestMoney", gm.money);
        }

        if (coll.gameObject.tag == "asteroid" )
        {
			hp = hp - (int)Random.Range(30,40);
            if (hp >= 0) {
                GameObject shields = ((Transform)Instantiate(shield, this.transform.position, this.transform.rotation)).gameObject;
                Destroy(shields, 0.1f);
            }
            else if (hp <= -1)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                gameObject.GetComponent<PolygonCollider2D>().enabled = false;
                GameObject booms = ((Transform)Instantiate(boom, this.transform.position, this.transform.rotation)).gameObject;
                Destroy(booms, 1f);
				if (clickRestart == 0) {
					reklamaBlock ();
				}
            }
        }
		if (coll.gameObject.tag == "asteroid1" )
		{
			hp = hp - (int)Random.Range(20,30);
			if (hp >= 0) {
				GameObject shields = ((Transform)Instantiate(shield, this.transform.position, this.transform.rotation)).gameObject;
				Destroy(shields, 0.1f);
			}
			else if (hp <= -1)
			{
				gameObject.GetComponent<SpriteRenderer>().enabled = false;
				gameObject.GetComponent<PolygonCollider2D>().enabled = false;
				GameObject booms = ((Transform)Instantiate(boom, this.transform.position, this.transform.rotation)).gameObject;
				Destroy(booms, 1f);
				if (clickRestart == 0) {
					reklamaBlock ();
				}
			}
		}
		if (coll.gameObject.tag == "asteroid2" )
		{
			hp = hp - (int)Random.Range(10,20);
			if (hp >= 0) {
				GameObject shields = ((Transform)Instantiate(shield, this.transform.position, this.transform.rotation)).gameObject;
				Destroy(shields, 0.1f);
			}
			else if (hp <= -1)
			{
				gameObject.GetComponent<SpriteRenderer>().enabled = false;
				gameObject.GetComponent<PolygonCollider2D>().enabled = false;
				GameObject booms = ((Transform)Instantiate(boom, this.transform.position, this.transform.rotation)).gameObject;
				Destroy(booms, 1f);
				if (clickRestart == 0) {
					reklamaBlock ();
				}
			}
		}
		if (coll.gameObject.tag == "trash" )
		{
			hp = hp - (int)Random.Range(1,5);
			if (hp >= 0) {
				GameObject shields = ((Transform)Instantiate(shield, this.transform.position, this.transform.rotation)).gameObject;
				Destroy(shields, 0.1f);
			}
			else if (hp <= -1)
			{
				gameObject.GetComponent<SpriteRenderer>().enabled = false;
				gameObject.GetComponent<PolygonCollider2D>().enabled = false;
				GameObject booms = ((Transform)Instantiate(boom, this.transform.position, this.transform.rotation)).gameObject;
				Destroy(booms, 1f);
				if (clickRestart == 0) {
					reklamaBlock ();
				}
			}
		}
		if (coll.gameObject.tag == "ships" )
		{
			hp = hp - (int)Random.Range(20,40);
			if (hp >= 0) {
				GameObject shields = ((Transform)Instantiate(shield, this.transform.position, this.transform.rotation)).gameObject;
				Destroy(shields, 0.1f);
			}
			else if (hp <= -1)
			{
				gameObject.GetComponent<SpriteRenderer>().enabled = false;
				gameObject.GetComponent<PolygonCollider2D>().enabled = false;
				GameObject booms = ((Transform)Instantiate(boom, this.transform.position, this.transform.rotation)).gameObject;
				Destroy(booms, 1f);
				if (clickRestart == 0) {
					reklamaBlock ();
				}
			}
		}
    }
    
	public void reklamaBlock(){
		ad = new InterstitialAd (gameOverAD);
		AdRequest request = new AdRequest.Builder ().Build ();
		//AdRequest request = new AdRequest.Builder ().AddTestDevice (AdRequest.TestDeviceSimulator).AddTestDevice ("3172DDD060FADA61").Build ();
		ad.LoadAd (request);
		ad.OnAdLoaded += OnAdLoaded;
	}

	void OnAdLoaded (object sender, System.EventArgs args)
	{
		ad.Show ();
	}

}
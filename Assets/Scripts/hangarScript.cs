using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using GoogleMobileAds.Api;

public class hangarScript : MonoBehaviour {

	public Image[] shield;
	public Image[] shield1;
	public Image[] shield2;
	public Image[] shield3;
	public Image[] shield4;
	public Image[] shield5;
	public Image[] shield6;
	public Image[] shield7;
	public Image[] shield8;
	public Image[] shield9;
	public Image[] shield10;


    public Image[] start;
    public Image[] buy1;
    public Image[] buy2;
    public Image[] buy3;
    public Image[] buy4;
    public Image[] buy5;
    public Image[] buy6;
    public Image[] buy7;
    public Image[] buy8;
    public Image[] buy9;
    public Image[] buy10;


    int bestMoneyS;
    public Text moneyTextS;

    public Image[] ship;
    public Image[] ship1;
    public Image[] ship2;
    public Image[] ship3;
    public Image[] ship4;
    public Image[] ship5;
    public Image[] ship6;
    public Image[] ship7;
    public Image[] ship8;
    public Image[] ship9;
    public Image[] ship10;

	public Image[] closeDoorBack;
	public Image[] closeDoor;
	public Image[] openDoor;

	private string helloCadet = "CgkI5rrPkZgPEAIQAw";

	private const string gameBonus = "ca-app-pub-4550678827778919/5643227981";
	private InterstitialAd ad;

    void Start()
    {
        PlayerPrefs.GetInt("nameShips");
        bestMoneyS = PlayerPrefs.GetInt("bestMoney");
		Time.timeScale = 1;
		setImageActiveDoorsOpen (true);
		GameObject openDoorObj = GameObject.Find ("doorsOpen");
		Destroy (openDoorObj, 1f);

		Social.ReportProgress(helloCadet, 100.0f, (bool success) =>
			{
			});
    }

    public void Update()
    {
        moneyTextS.text = "" + bestMoneyS;

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -4f, 5.3f);
        transform.position = pos;

        int nameShip = PlayerPrefs.GetInt("nameShips");
        if (nameShip == 0)
        {
            setImageActivenameShips(true);
            setImageActivenameShips1(false);
            setImageActivenameShips2(false);
            setImageActivenameShips3(false);
            setImageActivenameShips4(false);
            setImageActivenameShips5(false);
            setImageActivenameShips6(false);
            setImageActivenameShips7(false);
            setImageActivenameShips8(false);
            setImageActivenameShips9(false);
            setImageActivenameShips10(false);
            setImageActiveStart(true);
            setImageActiveBuy1(false);
            setImageActiveBuy2(false);
            setImageActiveBuy3(false);
            setImageActiveBuy4(false);
            setImageActiveBuy5(false);
            setImageActiveBuy6(false);
            setImageActiveBuy7(false);
            setImageActiveBuy8(false);
            setImageActiveBuy9(false);
            setImageActiveBuy10(false);
			setImageActiveShield (true);
			setImageActiveShield1(false);
			setImageActiveShield2(false);
			setImageActiveShield3(false);
			setImageActiveShield4(false);
			setImageActiveShield5(false);
			setImageActiveShield6(false);
			setImageActiveShield7(false);
			setImageActiveShield8(false);
			setImageActiveShield9(false);
			setImageActiveShield10(false);
        }

        int nameShip1 = PlayerPrefs.GetInt("nameShips");
        if (nameShip1 == 1)
        {
            setImageActivenameShips(false);
            setImageActivenameShips1(true);
            setImageActivenameShips2(false);
            setImageActivenameShips3(false);
            setImageActivenameShips4(false);
            setImageActivenameShips5(false);
            setImageActivenameShips6(false);
            setImageActivenameShips7(false);
            setImageActivenameShips8(false);
            setImageActivenameShips9(false);
            setImageActivenameShips10(false);
            setImageActiveBuy1(true);
            setImageActiveBuy2(false);
            setImageActiveBuy3(false);
            setImageActiveBuy4(false);
            setImageActiveBuy5(false);
            setImageActiveBuy6(false);
            setImageActiveBuy7(false);
            setImageActiveBuy8(false);
            setImageActiveBuy9(false);
            setImageActiveBuy10(false);
			setImageActiveShield (false);
			setImageActiveShield2(false);
			setImageActiveShield3(false);
			setImageActiveShield4(false);
			setImageActiveShield5(false);
			setImageActiveShield6(false);
			setImageActiveShield7(false);
			setImageActiveShield8(false);
			setImageActiveShield9(false);
			setImageActiveShield10(false);
            int sell1 = PlayerPrefs.GetInt("buy1");
            if (sell1 == 1)
            {
                setImageActiveStart(true);
                setImageActiveBuy1(false);
				setImageActiveShield1(true);
                //PlayerPrefs.DeleteKey("buy1");
            }
        }

        int nameShip2 = PlayerPrefs.GetInt("nameShips");
        if (nameShip2 == 2)
        {
            setImageActivenameShips(false);
            setImageActivenameShips1(false);
            setImageActivenameShips2(true);
            setImageActivenameShips3(false);
            setImageActivenameShips4(false);
            setImageActivenameShips5(false);
            setImageActivenameShips6(false);
            setImageActivenameShips7(false);
            setImageActivenameShips8(false);
            setImageActivenameShips9(false);
            setImageActivenameShips10(false);
            setImageActiveBuy1(false);
            setImageActiveBuy2(true);
            setImageActiveBuy3(false);
            setImageActiveBuy4(false);
            setImageActiveBuy5(false);
            setImageActiveBuy6(false);
            setImageActiveBuy7(false);
            setImageActiveBuy8(false);
            setImageActiveBuy9(false);
            setImageActiveBuy10(false);
			setImageActiveShield (false);
			setImageActiveShield1(false);
			setImageActiveShield3(false);
			setImageActiveShield4(false);
			setImageActiveShield5(false);
			setImageActiveShield6(false);
			setImageActiveShield7(false);
			setImageActiveShield8(false);
			setImageActiveShield9(false);
			setImageActiveShield10(false);
            int sell2 = PlayerPrefs.GetInt("buy2");
            if (sell2 == 1)
            {
                setImageActiveStart(true);
                setImageActiveBuy2(false);
				setImageActiveShield2(true);
                //PlayerPrefs.DeleteKey("buy2");
            }
        }

        int nameShip3 = PlayerPrefs.GetInt("nameShips");
        if (nameShip3 == 3)
        {
            setImageActivenameShips(false);
            setImageActivenameShips1(false);
            setImageActivenameShips2(false);
            setImageActivenameShips3(true);
            setImageActivenameShips4(false);
            setImageActivenameShips5(false);
            setImageActivenameShips6(false);
            setImageActivenameShips7(false);
            setImageActivenameShips8(false);
            setImageActivenameShips9(false);
            setImageActivenameShips10(false);
            setImageActiveBuy1(false);
            setImageActiveBuy2(false);
            setImageActiveBuy3(true);
            setImageActiveBuy4(false);
            setImageActiveBuy5(false);
            setImageActiveBuy6(false);
            setImageActiveBuy7(false);
            setImageActiveBuy8(false);
            setImageActiveBuy9(false);
            setImageActiveBuy10(false);
			setImageActiveShield (false);
			setImageActiveShield1(false);
			setImageActiveShield2(false);
			setImageActiveShield4(false);
			setImageActiveShield5(false);
			setImageActiveShield6(false);
			setImageActiveShield7(false);
			setImageActiveShield8(false);
			setImageActiveShield9(false);
			setImageActiveShield10(false);
            int sell3 = PlayerPrefs.GetInt("buy3");
            if (sell3 == 1)
            {
                setImageActiveStart(true);
                setImageActiveBuy3(false);
				setImageActiveShield3(true);
                //PlayerPrefs.DeleteKey("buy3");
            }
        }

        int nameShip4 = PlayerPrefs.GetInt("nameShips");
        if (nameShip4 == 4)
        {
            setImageActivenameShips(false);
            setImageActivenameShips1(false);
            setImageActivenameShips2(false);
            setImageActivenameShips3(false);
            setImageActivenameShips4(true);
            setImageActivenameShips5(false);
            setImageActivenameShips6(false);
            setImageActivenameShips7(false);
            setImageActivenameShips8(false);
            setImageActivenameShips9(false);
            setImageActivenameShips10(false);
            setImageActiveBuy1(false);
            setImageActiveBuy2(false);
            setImageActiveBuy3(false);
            setImageActiveBuy4(true);
            setImageActiveBuy5(false);
            setImageActiveBuy6(false);
            setImageActiveBuy7(false);
            setImageActiveBuy8(false);
            setImageActiveBuy9(false);
            setImageActiveBuy10(false);
			setImageActiveShield (false);
			setImageActiveShield1(false);
			setImageActiveShield2(false);
			setImageActiveShield3(false);
			setImageActiveShield5(false);
			setImageActiveShield6(false);
			setImageActiveShield7(false);
			setImageActiveShield8(false);
			setImageActiveShield9(false);
			setImageActiveShield10(false);
            int sell4 = PlayerPrefs.GetInt("buy4");
            if (sell4 == 1)
            {
                setImageActiveStart(true);
                setImageActiveBuy4(false);
				setImageActiveShield4(true);
                //PlayerPrefs.DeleteKey("buy4");
            }
        }

        int nameShip5 = PlayerPrefs.GetInt("nameShips");
        if (nameShip5 == 5)
        {
            setImageActivenameShips(false);
            setImageActivenameShips1(false);
            setImageActivenameShips2(false);
            setImageActivenameShips3(false);
            setImageActivenameShips4(false);
            setImageActivenameShips5(true);
            setImageActivenameShips6(false);
            setImageActivenameShips7(false);
            setImageActivenameShips8(false);
            setImageActivenameShips9(false);
            setImageActivenameShips10(false);
            setImageActiveBuy1(false);
            setImageActiveBuy2(false);
            setImageActiveBuy3(false);
            setImageActiveBuy4(false);
            setImageActiveBuy5(true);
            setImageActiveBuy6(false);
            setImageActiveBuy7(false);
            setImageActiveBuy8(false);
            setImageActiveBuy9(false);
            setImageActiveBuy10(false);
			setImageActiveShield (false);
			setImageActiveShield1(false);
			setImageActiveShield2(false);
			setImageActiveShield3(false);
			setImageActiveShield4(false);
			setImageActiveShield6(false);
			setImageActiveShield7(false);
			setImageActiveShield8(false);
			setImageActiveShield9(false);
			setImageActiveShield10(false);
            int sell5 = PlayerPrefs.GetInt("buy5");
            if (sell5 == 1)
            {
                setImageActiveStart(true);
                setImageActiveBuy5(false);
				setImageActiveShield5(true);
                //PlayerPrefs.DeleteKey("buy5");
            }
        }

        int nameShip6 = PlayerPrefs.GetInt("nameShips");
        if (nameShip6 == 6)
        {
            setImageActivenameShips(false);
            setImageActivenameShips1(false);
            setImageActivenameShips2(false);
            setImageActivenameShips3(false);
            setImageActivenameShips4(false);
            setImageActivenameShips5(false);
            setImageActivenameShips6(true);
            setImageActivenameShips7(false);
            setImageActivenameShips8(false);
            setImageActivenameShips9(false);
            setImageActivenameShips10(false);
            setImageActiveBuy1(false);
            setImageActiveBuy2(false);
            setImageActiveBuy3(false);
            setImageActiveBuy4(false);
            setImageActiveBuy5(false);
            setImageActiveBuy6(true);
            setImageActiveBuy7(false);
            setImageActiveBuy8(false);
            setImageActiveBuy9(false);
            setImageActiveBuy10(false);
			setImageActiveShield (false);
			setImageActiveShield1(false);
			setImageActiveShield2(false);
			setImageActiveShield3(false);
			setImageActiveShield4(false);
			setImageActiveShield5(false);
			setImageActiveShield7(false);
			setImageActiveShield8(false);
			setImageActiveShield9(false);
			setImageActiveShield10(false);
            int sell6 = PlayerPrefs.GetInt("buy6");
            if (sell6 == 1)
            {
                setImageActiveStart(true);
                setImageActiveBuy6(false);
				setImageActiveShield6(true);
                //PlayerPrefs.DeleteKey("buy6");
            }
        }

        int nameShip7 = PlayerPrefs.GetInt("nameShips");
        if (nameShip7 == 7)
        {
            setImageActivenameShips(false);
            setImageActivenameShips1(false);
            setImageActivenameShips2(false);
            setImageActivenameShips3(false);
            setImageActivenameShips4(false);
            setImageActivenameShips5(false);
            setImageActivenameShips6(false);
            setImageActivenameShips7(true);
            setImageActivenameShips8(false);
            setImageActivenameShips9(false);
            setImageActivenameShips10(false);
            setImageActiveBuy1(false);
            setImageActiveBuy2(false);
            setImageActiveBuy3(false);
            setImageActiveBuy4(false);
            setImageActiveBuy5(false);
            setImageActiveBuy6(false);
            setImageActiveBuy7(true);
            setImageActiveBuy8(false);
            setImageActiveBuy9(false);
            setImageActiveBuy10(false);
			setImageActiveShield (false);
			setImageActiveShield1(false);
			setImageActiveShield2(false);
			setImageActiveShield3(false);
			setImageActiveShield4(false);
			setImageActiveShield5(false);
			setImageActiveShield6(false);
			setImageActiveShield8(false);
			setImageActiveShield9(false);
			setImageActiveShield10(false);
            int sell7 = PlayerPrefs.GetInt("buy7");
            if (sell7 == 1)
            {
                setImageActiveStart(true);
                setImageActiveBuy7(false);
				setImageActiveShield7(true);
                //PlayerPrefs.DeleteKey("buy7");
            }
        }

        int nameShip8 = PlayerPrefs.GetInt("nameShips");
        if (nameShip8 == 8)
        {
            setImageActivenameShips(false);
            setImageActivenameShips1(false);
            setImageActivenameShips2(false);
            setImageActivenameShips3(false);
            setImageActivenameShips4(false);
            setImageActivenameShips5(false);
            setImageActivenameShips6(false);
            setImageActivenameShips7(false);
            setImageActivenameShips8(true);
            setImageActivenameShips9(false);
            setImageActivenameShips10(false);
            setImageActiveBuy1(false);
            setImageActiveBuy2(false);
            setImageActiveBuy3(false);
            setImageActiveBuy4(false);
            setImageActiveBuy5(false);
            setImageActiveBuy6(false);
            setImageActiveBuy7(false);
            setImageActiveBuy8(true);
            setImageActiveBuy9(false);
            setImageActiveBuy10(false);
			setImageActiveShield (false);
			setImageActiveShield1(false);
			setImageActiveShield2(false);
			setImageActiveShield3(false);
			setImageActiveShield4(false);
			setImageActiveShield5(false);
			setImageActiveShield6(false);
			setImageActiveShield7(false);
			setImageActiveShield9(false);
			setImageActiveShield10(false);
            int sell8 = PlayerPrefs.GetInt("buy8");
            if (sell8 == 1)
            {
                setImageActiveStart(true);
                setImageActiveBuy8(false);
				setImageActiveShield8(true);
                //PlayerPrefs.DeleteKey("buy8");
            }
        }

        int nameShip9 = PlayerPrefs.GetInt("nameShips");
        if (nameShip9 == 9)
        {
            setImageActivenameShips(false);
            setImageActivenameShips1(false);
            setImageActivenameShips2(false);
            setImageActivenameShips3(false);
            setImageActivenameShips4(false);
            setImageActivenameShips5(false);
            setImageActivenameShips6(false);
            setImageActivenameShips7(false);
            setImageActivenameShips8(false);
            setImageActivenameShips9(true);
            setImageActivenameShips10(false);
            setImageActiveBuy1(false);
            setImageActiveBuy2(false);
            setImageActiveBuy3(false);
            setImageActiveBuy4(false);
            setImageActiveBuy5(false);
            setImageActiveBuy6(false);
            setImageActiveBuy7(false);
            setImageActiveBuy8(false);
            setImageActiveBuy9(true);
            setImageActiveBuy10(false);
			setImageActiveShield (false);
			setImageActiveShield1(false);
			setImageActiveShield2(false);
			setImageActiveShield3(false);
			setImageActiveShield4(false);
			setImageActiveShield5(false);
			setImageActiveShield6(false);
			setImageActiveShield7(false);
			setImageActiveShield8(false);
			setImageActiveShield10(false);
            int sell9 = PlayerPrefs.GetInt("buy9");
            if (sell9 == 1)
            {
                setImageActiveStart(true);
                setImageActiveBuy9(false);
				setImageActiveShield9(true);
                //PlayerPrefs.DeleteKey("buy9");
            }
        }

        int nameShip10 = PlayerPrefs.GetInt("nameShips");
        if (nameShip10 == 10)
        {
            setImageActivenameShips(false);
            setImageActivenameShips1(false);
            setImageActivenameShips2(false);
            setImageActivenameShips3(false);
            setImageActivenameShips4(false);
            setImageActivenameShips5(false);
            setImageActivenameShips6(false);
            setImageActivenameShips7(false);
            setImageActivenameShips8(false);
            setImageActivenameShips9(false);
            setImageActivenameShips10(true);
            setImageActiveBuy1(false);
            setImageActiveBuy2(false);
            setImageActiveBuy3(false);
            setImageActiveBuy4(false);
            setImageActiveBuy5(false);
            setImageActiveBuy6(false);
            setImageActiveBuy7(false);
            setImageActiveBuy8(false);
            setImageActiveBuy9(false);
            setImageActiveBuy10(true);
			setImageActiveShield (false);
			setImageActiveShield1(false);
			setImageActiveShield2(false);
			setImageActiveShield3(false);
			setImageActiveShield4(false);
			setImageActiveShield5(false);
			setImageActiveShield6(false);
			setImageActiveShield7(false);
			setImageActiveShield8(false);
			setImageActiveShield9(false);
            int sell10 = PlayerPrefs.GetInt("buy10");
            if (sell10 == 1)
            {
                setImageActiveStart(true);
                setImageActiveBuy10(false);
				setImageActiveShield10(true);
                //PlayerPrefs.DeleteKey("buy10");
            }
        }
    }
        
                                                    //Touch button buy
    public void touchBuy1()
    {
        if (bestMoneyS >= 100)
        {
            bestMoneyS -= 100;
            PlayerPrefs.SetInt("bestMoney", bestMoneyS);
            PlayerPrefs.SetInt("buy1", 1);
        }
    }
    public void touchBuy2()
    {
        if (bestMoneyS >= 150)
        {
            bestMoneyS -= 150;
            PlayerPrefs.SetInt("bestMoney", bestMoneyS);
            PlayerPrefs.SetInt("buy2", 1);
        }
    }
    public void touchBuy3()
    {
        if (bestMoneyS >= 200)
        {
            bestMoneyS -= 200;
            PlayerPrefs.SetInt("bestMoney", bestMoneyS);
            PlayerPrefs.SetInt("buy3", 1);
        }
    }
    public void touchBuy4()
    {
        if (bestMoneyS >= 250)
        {
            bestMoneyS -= 250;
            PlayerPrefs.SetInt("bestMoney", bestMoneyS);
            PlayerPrefs.SetInt("buy4", 1);
        }
    }
    public void touchBuy5()
    {
        if (bestMoneyS >= 300)
        {
            bestMoneyS -= 300;
            PlayerPrefs.SetInt("bestMoney", bestMoneyS);
            PlayerPrefs.SetInt("buy5", 1);
        }
    }
    public void touchBuy6()
    {
        if (bestMoneyS >= 400)
        {
            bestMoneyS -= 400;
            PlayerPrefs.SetInt("bestMoney", bestMoneyS);
            PlayerPrefs.SetInt("buy6", 1);
        }
    }
    public void touchBuy7()
    {
        if (bestMoneyS >= 500)
        {
            bestMoneyS -= 500;
            PlayerPrefs.SetInt("bestMoney", bestMoneyS);
            PlayerPrefs.SetInt("buy7", 1);
        }
    }
    public void touchBuy8()
    {
        if (bestMoneyS >= 600)
        {
            bestMoneyS -= 600;
            PlayerPrefs.SetInt("bestMoney", bestMoneyS);
            PlayerPrefs.SetInt("buy8", 1);
        }
    }
    public void touchBuy9()
    {
        if (bestMoneyS >= 700)
        {
            bestMoneyS -= 700;
            PlayerPrefs.SetInt("bestMoney", bestMoneyS);
            PlayerPrefs.SetInt("buy9", 1);
        }
    }
    public void touchBuy10()
    {
        if (bestMoneyS >= 800)
        {
            bestMoneyS -= 800;
            PlayerPrefs.SetInt("bestMoney", bestMoneyS);
            PlayerPrefs.SetInt("buy10", 1);
        }
    }
																//shieldPanel
	public void setImageActiveShield(bool active)
	{
		foreach (Image imgShield in shield)
		{
			imgShield.gameObject.SetActive(active);
		}
	}
	public void setImageActiveShield1(bool active)
	{
		foreach (Image imgShield1 in shield1)
		{
			imgShield1.gameObject.SetActive(active);
		}
	}
	public void setImageActiveShield2(bool active)
	{
		foreach (Image imgShield2 in shield2)
		{
			imgShield2.gameObject.SetActive(active);
		}
	}
	public void setImageActiveShield3(bool active)
	{
		foreach (Image imgShield3 in shield3)
		{
			imgShield3.gameObject.SetActive(active);
		}
	}
	public void setImageActiveShield4(bool active)
	{
		foreach (Image imgShield4 in shield4)
		{
			imgShield4.gameObject.SetActive(active);
		}
	}
	public void setImageActiveShield5(bool active)
	{
		foreach (Image imgShield5 in shield5)
		{
			imgShield5.gameObject.SetActive(active);
		}
	}
	public void setImageActiveShield6(bool active)
	{
		foreach (Image imgShield6 in shield6)
		{
			imgShield6.gameObject.SetActive(active);
		}
	}
	public void setImageActiveShield7(bool active)
	{
		foreach (Image imgShield7 in shield7)
		{
			imgShield7.gameObject.SetActive(active);
		}
	}
	public void setImageActiveShield8(bool active)
	{
		foreach (Image imgShield8 in shield8)
		{
			imgShield8.gameObject.SetActive(active);
		}
	}
	public void setImageActiveShield9(bool active)
	{
		foreach (Image imgShield9 in shield9)
		{
			imgShield9.gameObject.SetActive(active);
		}
	}
	public void setImageActiveShield10(bool active)
	{
		foreach (Image imgShield10 in shield10)
		{
			imgShield10.gameObject.SetActive(active);
		}
	}

    //Active Start and Buy button
    public void setImageActiveStart(bool active)
    {
        foreach (Image imgStart in start)
        {
            imgStart.gameObject.SetActive(active);
        }
    }
    public void setImageActiveBuy1(bool active)
    {
        foreach (Image imgBuy1 in buy1)
        {
            imgBuy1.gameObject.SetActive(active);
        }
    }
    public void setImageActiveBuy2(bool active)
    {
        foreach (Image imgBuy2 in buy2)
        {
            imgBuy2.gameObject.SetActive(active);
        }
    }
    public void setImageActiveBuy3(bool active)
    {
        foreach (Image imgBuy3 in buy3)
        {
            imgBuy3.gameObject.SetActive(active);
        }
    }
    public void setImageActiveBuy4(bool active)
    {
        foreach (Image imgBuy4 in buy4)
        {
            imgBuy4.gameObject.SetActive(active);
        }
    }
    public void setImageActiveBuy5(bool active)
    {
        foreach (Image imgBuy5 in buy5)
        {
            imgBuy5.gameObject.SetActive(active);
        }
    }
    public void setImageActiveBuy6(bool active)
    {
        foreach (Image imgBuy6 in buy6)
        {
            imgBuy6.gameObject.SetActive(active);
        }
    }
    public void setImageActiveBuy7(bool active)
    {
        foreach (Image imgBuy7 in buy7)
        {
            imgBuy7.gameObject.SetActive(active);
        }
    }
    public void setImageActiveBuy8(bool active)
    {
        foreach (Image imgBuy8 in buy8)
        {
            imgBuy8.gameObject.SetActive(active);
        }
    }
    public void setImageActiveBuy9(bool active)
    {
        foreach (Image imgBuy9 in buy9)
        {
            imgBuy9.gameObject.SetActive(active);
        }
    }
    public void setImageActiveBuy10(bool active)
    {
        foreach (Image imgBuy10 in buy10)
        {
            imgBuy10.gameObject.SetActive(active);
        }
    }


    //Active nameShips
    public void setImageActivenameShips(bool active)
    {
        foreach (Image imgShip in ship)
        {
            imgShip.gameObject.SetActive(active);
        }
    }
    public void setImageActivenameShips1(bool active)
    {
        foreach (Image imgShip1 in ship1)
        {
            imgShip1.gameObject.SetActive(active);
        }
    }
    public void setImageActivenameShips2(bool active)
    {
        foreach (Image imgShip2 in ship2)
        {
            imgShip2.gameObject.SetActive(active);
        }
    }
    public void setImageActivenameShips3(bool active)
    {
        foreach (Image imgShip3 in ship3)
        {
            imgShip3.gameObject.SetActive(active);
        }
    }
    public void setImageActivenameShips4(bool active)
    {
        foreach (Image imgShip4 in ship4)
        {
            imgShip4.gameObject.SetActive(active);
        }
    }
    public void setImageActivenameShips5(bool active)
    {
        foreach (Image imgShip5 in ship5)
        {
            imgShip5.gameObject.SetActive(active);
        }
    }
    public void setImageActivenameShips6(bool active)
    {
        foreach (Image imgShip6 in ship6)
        {
            imgShip6.gameObject.SetActive(active);
        }
    }
    public void setImageActivenameShips7(bool active)
    {
        foreach (Image imgShip7 in ship7)
        {
            imgShip7.gameObject.SetActive(active);
        }
    }
    public void setImageActivenameShips8(bool active)
    {
        foreach (Image imgShip8 in ship8)
        {
            imgShip8.gameObject.SetActive(active);
        }
    }
    public void setImageActivenameShips9(bool active)
    {
        foreach (Image imgShip9 in ship9)
        {
            imgShip9.gameObject.SetActive(active);
        }
    }
    public void setImageActivenameShips10(bool active)
    {
        foreach (Image imgShip10 in ship10)
        {
            imgShip10.gameObject.SetActive(active);
        }
    }

                                        //button back and start
    public void backMenu()
    {
        SceneManager.LoadScene("MainScreen");
    }

	public void money25Shield()
	{
		if (bestMoneyS >= 50)
		{
			bestMoneyS -= 50;
			PlayerPrefs.SetInt("bestMoney", bestMoneyS);
			PlayerPrefs.SetInt("shield100", 1);
		}
	}

	public void reklamaShield()
	{
		videoReklama ();
		PlayerPrefs.SetInt("bestMoney", bestMoneyS);
		PlayerPrefs.SetInt("shield100", 1);
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
	public void setImageActiveDoorsOpen(bool active)
	{
		foreach (Image imgStart in openDoor)
		{
			imgStart.gameObject.SetActive(active);
		}
	}
	public void back()
	{
		setImageActiveDoorsCloseBack(true);
	}
	public void setImageActiveDoorsCloseBack(bool active)
	{
		foreach (Image imgStart in closeDoorBack)
		{
			imgStart.gameObject.SetActive(active);
		}
	}
}
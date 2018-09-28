using UnityEngine;
using System.Collections;

public class idStartShip : MonoBehaviour {
    
    public int idStart;

    public idScript ids;

    void Start () {

    }
	
	void Update () {
	
	}

    public void conShips()
    {
        idStart = PlayerPrefs.GetInt("nameShips", ids.idNameShips);
        PlayerPrefs.SetInt("startShip", idStart);
    }
}

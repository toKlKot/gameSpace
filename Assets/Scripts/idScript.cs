using UnityEngine;
using System.Collections;

public class idScript : MonoBehaviour {

    public int idNameShips;

    
    

    void Start () {
        PlayerPrefs.GetInt("nameShips", idNameShips);
	}
	
	void Update () {
        
    }
    public void touchShips()
    {
        PlayerPrefs.SetInt("nameShips", idNameShips);
    }

    


}

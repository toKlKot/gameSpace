using UnityEngine;
using System.Collections;

public class boomScript : MonoBehaviour
{

    public float speed;
    
    

    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
        
		if (PlayerPrefs.GetString("Music") == "no")
			GetComponent<AudioSource>().mute = true;
		else if (PlayerPrefs.GetString("Music") == "yes")
			GetComponent<AudioSource>().mute = false;
    }

    

}



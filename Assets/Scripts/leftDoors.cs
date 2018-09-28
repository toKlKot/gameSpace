using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class leftDoors : MonoBehaviour {

	float speed = 5f;
	public Transform leftDoor;
	public string levelScene;

	void Start () {
		speed = 5f;
		Time.timeScale = 1;
	}

	void Update () {
		transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
		if (transform.position.x > 0) {
			speed = 0;

		}
		if (speed == 0) {
			SceneManager.LoadScene (levelScene);
		}
		if (PlayerPrefs.GetString("Music") == "no")
			GetComponent<AudioSource>().mute = true;
		else if (PlayerPrefs.GetString("Music") == "yes")
			GetComponent<AudioSource>().mute = false;
	}

}

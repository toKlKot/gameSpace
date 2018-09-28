using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class finishGame : MonoBehaviour {




	void Start () {
		Vector3 pos = transform.position;
		pos.y = 0.26f;
		transform.position = pos;
	}


	public void restartGame()
	{
		SceneManager.LoadScene("GameScreen");
	}


	public void backMenu()
	{

		SceneManager.LoadScene("HangarScreen");
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class leftDoorsOpen : MonoBehaviour {

	float speed = 5f;
	public Transform leftDoor;
	public Image[] doorsOpen;

	void Start () {
		speed = 5f;
		Time.timeScale = 1;
	}

	void Update () {
		transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
		if (transform.position.x < -4) {
			speed = 0;
			//leftDoor = GameObject.Find ("leftDoors").transform;
			leftDoor.gameObject.SetActive (false);
			setImageActiveDoorsOpen (false);
		}

	}
	public void setImageActiveDoorsOpen(bool active)
	{
		foreach (Image imgStart in doorsOpen)
		{
			imgStart.gameObject.SetActive(active);
		}
	}
}

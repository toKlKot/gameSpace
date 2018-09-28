using UnityEngine;
using System.Collections;

public class rightDoorsOpen : MonoBehaviour {

	float speed = 5f;
	public Transform rightDoor;

	void Start () {
		speed = 5f;
	}

	void Update () {
		transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
		if (transform.position.x > 4) {
			speed = 0;
			//rightDoor = GameObject.Find ("rightDoors").transform;
			rightDoor.gameObject.SetActive (false);
		}
	}
}

using UnityEngine;
using System.Collections;

public class rightDoors : MonoBehaviour {

	float speed = 5f;
	public Transform rightDoorsR;

	void Start () {
		speed = 5f;
	}

	void Update () {
		transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
		if (transform.position.x < 0) {
			speed = 0;
		}
	}
}

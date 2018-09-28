using UnityEngine;
using System.Collections;

public class manScriptHelp : MonoBehaviour
{

	public float speed;
	public Transform blood;
	gameManager gm;
	GameObject obj;

	void Start()
	{
		obj = GameObject.Find("gameManager");
		gm = (gameManager)obj.GetComponent(typeof(gameManager));
	}

	void Update()
	{
		if (PlayerPrefs.GetString("Music") == "no")
			GetComponent<AudioSource>().mute = true;
		else if (PlayerPrefs.GetString("Music") == "yes")
			GetComponent<AudioSource>().mute = false;

		transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);

		if (gm.timer >= 10f)
		{
			speed = 3.1f;
		}
		if (gm.timer >= 20f)
		{
			speed = 3.2f;
		}
		if (gm.timer >= 30f)
		{
			speed = 3.3f;
			GetComponent<Rigidbody2D>().gravityScale = 0.2f;
		}
		if (gm.timer >= 40f)
		{
			speed = 3.4f;
		}
		if (gm.timer >= 50f)
		{
			speed = 3.5f;
			GetComponent<Rigidbody2D>().gravityScale = 0.3f;
		}
		if (gm.timer >= 60f)
		{
			speed = 4f;
			GetComponent<Rigidbody2D>().gravityScale = 0.4f;
		}
		if (gm.timer >= 90f)
		{
			speed = 4.5f;
			GetComponent<Rigidbody2D>().gravityScale = 0.45f;
		}
		if (gm.timer >= 120f)
		{
			speed = 5f;
		}
		if (gm.timer >= 150f)
		{
			speed = 5.5f;
			GetComponent<Rigidbody2D>().gravityScale = 0.5f;
		}

	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.tag == "asteroid" || coll.gameObject.tag == "asteroid1" || coll.gameObject.tag == "asteroid2" || coll.gameObject.tag == "trash" || coll.gameObject.tag == "actor" || coll.gameObject.tag == "ships") {
			Destroy(gameObject);
			GameObject bloods = ((Transform)Instantiate(blood, this.transform.position, this.transform.rotation)).gameObject;
			Destroy(bloods, 1f);
		}

		if (coll.gameObject.tag == "blockDestroy")
		{

			Destroy(gameObject);
		}
	}


}

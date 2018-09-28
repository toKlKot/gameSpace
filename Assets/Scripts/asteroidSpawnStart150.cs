using UnityEngine;
using System.Collections;

public class asteroidSpawnStart150 : MonoBehaviour
{


	public float maxPos;
	public float minPos;
	public float posZ;

	float timer;
	public float delay;

	public GameObject[] obj;

	gameManager gm;
	GameObject obj1;

	void Start()
	{
		obj1 = GameObject.Find("gameManager");
		gm = (gameManager)obj1.GetComponent(typeof(gameManager));

		timer = delay;
	}

	void Update()
	{
		timer = timer - Time.deltaTime;
		if (timer <= 0)
		{
			int objN = Random.Range(0, 24);
			Vector3 objPos = new Vector3(Random.Range(minPos, maxPos), transform.position.y, posZ);
			Transform.Instantiate(obj[objN], objPos, transform.rotation);
			timer = delay;
		}

		if (gm.timer >= 10f) { delay = 1f; }
		if (gm.timer >= 20f) { delay = 1.05f; }
		if (gm.timer >= 30f) { delay = 1.1f; }
		if (gm.timer >= 40f) { delay = 1.15f; }
		if (gm.timer >= 50f) { delay = 1.2f; }
		if (gm.timer >= 60f) { delay = 1.25f; }
		if (gm.timer >= 70f) { delay = 1.3f; }
		if (gm.timer >= 80f) { delay = 1.35f; }
		if (gm.timer >= 90f) { delay = 1.4f; }
		if (gm.timer >= 100f) { delay = 1.45f; }
		if (gm.timer >= 110f) { delay = 1.5f; }
		if (gm.timer >= 120f) { delay = 1.55f; }
		if (gm.timer >= 130f) { delay = 1.6f; }
		if (gm.timer >= 140f) { delay = 1.65f; }
		if (gm.timer >= 150f) { delay = 1.7f; }
		if (gm.timer >= 160f) { delay = 1.75f; }
		if (gm.timer >= 170f) { delay = 1.8f; }
		if (gm.timer >= 180f) { delay = 1.85f; }
		if (gm.timer >= 190f) { delay = 1.9f; }
		if (gm.timer >= 200f) { delay = 1.95f; }
		if (gm.timer >= 220f) { delay = 2f; }
		if (gm.timer >= 240f) { delay = 2.1f; }
		if (gm.timer >= 260f) { delay = 2.2f; }
		if (gm.timer >= 280f) { delay = 2.3f; }
		if (gm.timer >= 300f) { delay = 2.4f; }
		if (gm.timer >= 320f) { delay = 2.5f; }
		if (gm.timer >= 340f) { delay = 2.6f; }
		if (gm.timer >= 360f) { delay = 2.7f; }
		if (gm.timer >= 380f) { delay = 2.8f; }
		if (gm.timer >= 400f) { delay = 2.9f; }
		if (gm.timer >= 450f) { delay = 3f; }
		if (gm.timer >= 500f) { delay = 3.1f; }
		if (gm.timer >= 550f) { delay = 3.2f; }
		if (gm.timer >= 600f) { delay = 3.3f; }
		if (gm.timer >= 650f) { delay = 3.4f; }
		if (gm.timer >= 700f) { delay = 3.5f; }
		if (gm.timer >= 750f) { delay = 3.6f; }
		if (gm.timer >= 800f) { delay = 3.7f; }
		if (gm.timer >= 850f) { delay = 3.8f; }
		if (gm.timer >= 900f) { delay = 3.9f; }
		if (gm.timer >= 950f) { delay = 4f; }
		if (gm.timer >= 1000f) { delay = 4.1f; }
		if (gm.timer >= 1100f) { delay = 4.2f; }
		if (gm.timer >= 1200f) { delay = 4.3f; }
		if (gm.timer >= 1300f) { delay = 4.4f; }
		if (gm.timer >= 1400f) { delay = 4.5f; }
		if (gm.timer >= 1500f) { delay = 4.6f; }
		if (gm.timer >= 1600f) { delay = 4.7f; }
		if (gm.timer >= 1700f) { delay = 4.8f; }
		if (gm.timer >= 1800f) { delay = 4.9f; }
		if (gm.timer >= 1900f) { delay = 5f; }
	}

	void onDestroy()
	{

	}
}

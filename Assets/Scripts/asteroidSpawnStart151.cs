using UnityEngine;
using System.Collections;

public class asteroidSpawnStart151 : MonoBehaviour
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

		if (gm.timer >= 10f) { delay = 1.51f; }
		if (gm.timer >= 20f) { delay = 1.52f; }
		if (gm.timer >= 30f) { delay = 1.53f; }
		if (gm.timer >= 40f) { delay = 1.54f; }
		if (gm.timer >= 50f) { delay = 1.55f; }
		if (gm.timer >= 60f) { delay = 1.56f; }
		if (gm.timer >= 70f) { delay = 1.57f; }
		if (gm.timer >= 80f) { delay = 1.58f; }
		if (gm.timer >= 90f) { delay = 1.59f; }
		if (gm.timer >= 100f) { delay = 1.6f; }
		if (gm.timer >= 110f) { delay = 1.61f; }
		if (gm.timer >= 120f) { delay = 1.62f; }
		if (gm.timer >= 130f) { delay = 1.63f; }
		if (gm.timer >= 140f) { delay = 1.64f; }
		if (gm.timer >= 150f) { delay = 1.65f; }
		if (gm.timer >= 160f) { delay = 1.66f; }
		if (gm.timer >= 170f) { delay = 1.67f; }
		if (gm.timer >= 180f) { delay = 1.68f; }
		if (gm.timer >= 190f) { delay = 1.69f; }
		if (gm.timer >= 200f) { delay = 1.7f; }
		if (gm.timer >= 220f) { delay = 1.71f; }
		if (gm.timer >= 240f) { delay = 1.72f; }
		if (gm.timer >= 260f) { delay = 1.73f; }
		if (gm.timer >= 280f) { delay = 1.74f; }
		if (gm.timer >= 300f) { delay = 1.75f; }
		if (gm.timer >= 320f) { delay = 1.76f; }
		if (gm.timer >= 340f) { delay = 1.77f; }
		if (gm.timer >= 360f) { delay = 1.78f; }
		if (gm.timer >= 380f) { delay = 1.79f; }
		if (gm.timer >= 400f) { delay = 1.8f; }
		if (gm.timer >= 450f) { delay = 1.81f; }
		if (gm.timer >= 500f) { delay = 1.82f; }
		if (gm.timer >= 550f) { delay = 1.83f; }
		if (gm.timer >= 600f) { delay = 1.84f; }
		if (gm.timer >= 650f) { delay = 1.85f; }
		if (gm.timer >= 700f) { delay = 1.86f; }
		if (gm.timer >= 750f) { delay = 1.87f; }
		if (gm.timer >= 800f) { delay = 1.88f; }
		if (gm.timer >= 850f) { delay = 1.89f; }
		if (gm.timer >= 900f) { delay = 1.9f; }
		if (gm.timer >= 950f) { delay = 1.91f; }
		if (gm.timer >= 1000f) { delay = 1.92f; }
		if (gm.timer >= 1100f) { delay = 1.93f; }
		if (gm.timer >= 1200f) { delay = 1.94f; }
		if (gm.timer >= 1300f) { delay = 1.95f; }
		if (gm.timer >= 1400f) { delay = 1.96f; }
		if (gm.timer >= 1500f) { delay = 1.97f; }
		if (gm.timer >= 1600f) { delay = 1.98f; }
		if (gm.timer >= 1700f) { delay = 1.99f; }
		if (gm.timer >= 1800f) { delay = 2f; }
		if (gm.timer >= 1900f) { delay = 3f; }
	}

	void onDestroy()
	{

	}
}

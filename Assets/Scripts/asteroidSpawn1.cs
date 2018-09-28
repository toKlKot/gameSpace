using UnityEngine;
using System.Collections;

public class asteroidSpawn1 : MonoBehaviour
{


    public float maxPos;
    public float minPos;
    public float posZ;

    float timer;
    public float delay = 1.5f;

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
            int objN = Random.Range(0, 8);
            Vector3 objPos = new Vector3(Random.Range(minPos, maxPos), transform.position.y, posZ);
            Transform.Instantiate(obj[objN], objPos, transform.rotation);
            timer = delay;
        }

		if (gm.timer >= 10f) { delay = 1.9f; }
		if (gm.timer >= 20f) { delay = 1.8f; }
		if (gm.timer >= 30f) { delay = 1.7f; }
		if (gm.timer >= 40f) { delay = 1.6f; }
		if (gm.timer >= 50f) { delay = 1.5f; }
		if (gm.timer >= 60f) { delay = 1.45f; }
		if (gm.timer >= 70f) { delay = 1.4f; }
		if (gm.timer >= 80f) { delay = 1.35f; }
		if (gm.timer >= 90f) { delay = 1.3f; }
		if (gm.timer >= 100f) { delay = 1.25f; }
		if (gm.timer >= 200f) { delay = 1.2f; }
		if (gm.timer >= 300f) { delay = 1.15f; }
		if (gm.timer >= 400f) { delay = 1.1f; }
		if (gm.timer >= 500f) { delay = 1.05f; }
		if (gm.timer >= 600f) { delay = 1f; }
		if (gm.timer >= 700f) { delay = 0.95f; }
		if (gm.timer >= 800f) { delay = 0.9f; }
		if (gm.timer >= 900f) { delay = 0.85f; }
		if (gm.timer >= 1000f) { delay = 0.8f; }
		if (gm.timer >= 1100f) { delay = 0.75f; }
		if (gm.timer >= 1200f) { delay = 0.7f; }
		if (gm.timer >= 1300f) { delay = 0.65f; }
		if (gm.timer >= 1400f) { delay = 0.6f; }
		if (gm.timer >= 1500f) { delay = 0.55f; }
    }

    void onDestroy()
    {

    }
}

using UnityEngine;
using System.Collections;

public class planetsSpawn : MonoBehaviour {


    public float maxPos;
    public float minPos;
	public float posZ;

	float timer;
	public float delay;

	public GameObject[] obj;

    gameManager gm;
    GameObject obj1;

    void Start () {
        obj1 = GameObject.Find("gameManager");
        gm = (gameManager)obj1.GetComponent(typeof(gameManager));

        timer = delay;
	}

	void Update () {
		timer = timer - Time.deltaTime;
		if(timer <= 0)
		{
			int objN = Random.Range(0, 14);
			Vector3 objPos = new Vector3 (Random.Range (minPos, maxPos), transform.position.y, posZ);
			Transform.Instantiate (obj [objN], objPos, transform.rotation);
			timer = delay;
		}

        if (gm.timer >= 60f) { delay = 6.9f; }
        if (gm.timer >= 90f) { delay = 6.8f; }
        if (gm.timer >= 120f) { delay = 6.7f; }
        if (gm.timer >= 150f) { delay = 6.6f; }
        if (gm.timer >= 180f) { delay = 6.5f; }
        if (gm.timer >= 210f) { delay = 6.4f; }
        if (gm.timer >= 240f) { delay = 6.3f; }
        if (gm.timer >= 270f) { delay = 6.2f; }
        if (gm.timer >= 300f) { delay = 6.1f; }
        if (gm.timer >= 330f) { delay = 6f; }
        if (gm.timer >= 400f) { delay = 5.9f; }
        if (gm.timer >= 500f) { delay = 5.8f; }
        if (gm.timer >= 600f) { delay = 5.7f; }
        if (gm.timer >= 700f) { delay = 5.6f; }
        if (gm.timer >= 800f) { delay = 5.5f; }
        if (gm.timer >= 900f) { delay = 5.4f; }
        if (gm.timer >= 1000f) { delay = 5.3f; }
        if (gm.timer >= 1200f) { delay = 5.2f; }
        if (gm.timer >= 1300f) { delay = 5.1f; }
        if (gm.timer >= 1400f) { delay = 5f; }
    }

	void onDestroy()
	{

	}
}

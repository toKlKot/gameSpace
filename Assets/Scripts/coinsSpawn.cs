using UnityEngine;
using System.Collections;

public class coinsSpawn : MonoBehaviour
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
            int objN = Random.Range(0, 1);
            Vector3 objPos = new Vector3(Random.Range(minPos, maxPos), transform.position.y, posZ);
            Transform.Instantiate(obj[objN], objPos, transform.rotation);
            timer = delay;
        }

		if (gm.timer >= 300f) { delay = 18f; }
		if (gm.timer >= 500f) { delay = 15f; }
		if (gm.timer >= 750f) { delay = 13f; }
		if (gm.timer >= 1000f) { delay = 10f; }
		if (gm.timer >= 1250f) { delay = 9f; }
		if (gm.timer >= 1500f) { delay = 8f; }
		if (gm.timer >= 1750f) { delay = 7f; }
    }

    void onDestroy()
    {

    }
}

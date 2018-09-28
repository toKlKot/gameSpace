using UnityEngine;
using System.Collections;

public class shieldSpawn : MonoBehaviour
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
            int objN = Random.Range(0, 1);
            Vector3 objPos = new Vector3(Random.Range(minPos, maxPos), transform.position.y, posZ);
            Transform.Instantiate(obj[objN], objPos, transform.rotation);
            timer = delay;
        }

        if (gm.timer >= 60f) { delay = 12.5f; }
        if (gm.timer >= 120f) { delay = 12f; }
        if (gm.timer >= 180f) { delay = 11.5f; }
        if (gm.timer >= 240f) { delay = 11f; }
        if (gm.timer >= 300f) { delay = 10.5f; }
        if (gm.timer >= 400f) { delay = 10f; }
        if (gm.timer >= 500f) { delay = 9.9f; }
        if (gm.timer >= 600f) { delay = 9.8f; }
        if (gm.timer >= 700f) { delay = 9.7f; }
        if (gm.timer >= 800f) { delay = 9.6f; }
        if (gm.timer >= 900f) { delay = 9.5f; }
        if (gm.timer >= 1000f) { delay = 9.4f; }
		if (gm.timer >= 1200f) { delay = 9.3f; }
		if (gm.timer >= 1400f) { delay = 9.2f; }
		if (gm.timer >= 1600f) { delay = 9.1f; }
		if (gm.timer >= 1800f) { delay = 9f; }
    }

    void onDestroy()
    {

    }
}

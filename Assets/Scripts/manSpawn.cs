using UnityEngine;
using System.Collections;

public class manSpawn : MonoBehaviour
{


    public float maxPos;
    public float minPos;
    public float posZ;

    float timer;
    public float delay;

    public GameObject[] obj;

    void Start()
    {
        timer = delay;
    }

    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {
            int objN = Random.Range(0, 6);
            Vector3 objPos = new Vector3(Random.Range(minPos, maxPos), transform.position.y, posZ);
            Transform.Instantiate(obj[objN], objPos, transform.rotation);
            timer = delay;
        }
    }

    void onDestroy()
    {

    }
}

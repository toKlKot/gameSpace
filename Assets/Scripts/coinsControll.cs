using UnityEngine;
using System.Collections;

public class coinsControll : MonoBehaviour
{

    public float speed;

    gameManager gm;
    GameObject obj;

    void Start()
    {
        obj = GameObject.Find("gameManager");
        gm = (gameManager)obj.GetComponent(typeof(gameManager));
    }

    void Update()
    {
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
        }
        if (gm.timer >= 40f)
        {
            speed = 3.4f;
        }
        if (gm.timer >= 50f)
        {
            speed = 3.5f;
        }
        if (gm.timer >= 60f)
        {
            speed = 4f;
        }
        if (gm.timer >= 90f)
        {
            speed = 4.5f;
        }
        if (gm.timer >= 120f)
        {
            speed = 5f;
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "blockDestroy" || coll.gameObject.tag == "actor" || coll.gameObject.tag == "ships")

            Destroy(gameObject);
    }


}


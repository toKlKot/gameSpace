using UnityEngine;
using System.Collections;

public class planetsControll : MonoBehaviour
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
            speed = 2.9f;
        }
        if (gm.timer >= 20f)
        {
            speed = 3f;
        }
        if (gm.timer >= 30f)
        {
            speed = 3.1f;
        }
        if (gm.timer >= 40f)
        {
            speed = 3.2f;
        }
        if (gm.timer >= 50f)
        {
            speed = 3.3f;
        }
        if (gm.timer >= 60f)
        {
            speed = 3.5f;
        }
        if (gm.timer >= 70f)
        {
            speed = 4.1f;
        }
        if (gm.timer >= 80f)
        {
            speed = 4.2f;
        }
        if (gm.timer >= 90f)
        {
            speed = 4.3f;
        }
        if (gm.timer >= 100f)
        {
            speed = 4.4f;
        }
        if (gm.timer >= 110f)
        {
            speed = 4.5f;
        }
        if (gm.timer >= 120f)
        {
            speed = 4.6f;
        }
        if (gm.timer >= 130f)
        {
            speed = 4.7f;
        }
        if (gm.timer >= 140f)
        {
            speed = 4.8f;
        }
        if (gm.timer >= 150f)
        {
            speed = 4.9f;
        }
        if (gm.timer >= 160f)
        {
            speed = 5f;
        }
        /*if (gm.timer >= 170f)
        {
            speed = 5.1f;
        }
        if (gm.timer >= 180f)
        {
            speed = 5.2f;
        }
        if (gm.timer >= 190f)
        {
            speed = 5.3f;
        }
        if (gm.timer >= 200f)
        {
            speed = 5.4f;
        }
        if (gm.timer >= 210f)
        {
            speed = 5.5f;
        }
        if (gm.timer >= 220f)
        {
            speed = 5.6f;
        }
        if (gm.timer >= 230f)
        {
            speed = 5.7f;
        }
        if (gm.timer >= 240f)
        {
            speed = 5.8f;
        }
        if (gm.timer >= 250f)
        {
            speed = 5.9f;
        }
        if (gm.timer >= 260f)
        {
            speed = 6f;
        }
        if (gm.timer >= 280f)
        {
            speed = 6.1f;
        }
        if (gm.timer >= 300f)
        {
            speed = 6.2f;
        }*/

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "blockDestroy1")

            Destroy(gameObject);
    }


}


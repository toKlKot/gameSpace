using UnityEngine;
using System.Collections;

public class shipControll : MonoBehaviour
{

    public float speed;
    public Transform boom;
    public int hp;
    public int damage;
    public Transform shield;

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
            speed = 1.1f;
        }
        if (gm.timer >= 20f)
        {
            speed = 1.2f;
        }
        if (gm.timer >= 30f)
        {
            speed = 1.3f;
        }
        if (gm.timer >= 40f)
        {
            speed = 1.4f;
        }
        if (gm.timer >= 50f)
        {
            speed = 1.5f;
        }
        if (gm.timer >= 60f)
        {
            speed = 2f;
        }
        if (gm.timer >= 70f)
        {
            speed = 2.2f;
        }
        if (gm.timer >= 80f)
        {
            speed = 2.4f;
        }
        if (gm.timer >= 90f)
        {
            speed = 2.6f;
        }
        if (gm.timer >= 100f)
        {
            speed = 2.8f;
        }
        if (gm.timer >= 110f)
        {
            speed = 3f;
        }
        if (gm.timer >= 120f)
        {
            speed = 3.2f;
        }
        if (gm.timer >= 130f)
        {
            speed = 3.4f;
        }
        if (gm.timer >= 140f)
        {
            speed = 3.6f;
        }
        if (gm.timer >= 150f)
        {
            speed = 3.8f;
        }
        if (gm.timer >= 160f)
        {
            speed = 4f;
        }
        if (gm.timer >= 170f)
        {
            speed = 4.2f;
        }
        if (gm.timer >= 180f)
        {
            speed = 4.4f;
        }
        if (gm.timer >= 190f)
        {
            speed = 4.6f;
        }
        if (gm.timer >= 200f)
        {
            speed = 4.8f;
        }
        if (gm.timer >= 210f)
        {
            speed = 5f;
        }
        if (gm.timer >= 220f)
        {
            speed = 5.2f;
        }
        if (gm.timer >= 230f)
        {
            speed = 5.4f;
        }
        if (gm.timer >= 240f)
        {
            speed = 5.6f;
        }
        if (gm.timer >= 250f)
        {
            speed = 5.8f;
        }
        if (gm.timer >= 260f)
        {
            speed = 6f;
        }
        if (gm.timer >= 280f)
        {
            speed = 6.2f;
        }
        if (gm.timer >= 300f)
        {
            speed = 6.4f;
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "man" || coll.gameObject.tag == "coins")
        {

        }
        if (coll.gameObject.tag == "shield25")
        {
            hp += 25;
        }

		if (coll.gameObject.tag == "blockDestroy") {
			Destroy (gameObject);
		}

		if (coll.gameObject.tag == "asteroid" || coll.gameObject.tag == "asteroid1" || coll.gameObject.tag == "asteroid2" || coll.gameObject.tag == "trash" || coll.gameObject.tag == "ships" || coll.gameObject.tag == "actor")
        {
            hp = hp - 1;
            if (hp > 1)
            {
                GameObject shields = ((Transform)Instantiate(shield, this.transform.position, this.transform.rotation)).gameObject;
                Destroy(shields, 0.1f);
            }
            else if (hp <= -1)
            {
                Destroy(gameObject);
                GameObject booms = ((Transform)Instantiate(boom, this.transform.position, this.transform.rotation)).gameObject;
                Destroy(booms, 1f);
            }
        }
    }

}



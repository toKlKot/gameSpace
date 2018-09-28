using UnityEngine;
using System.Collections;

public class asteroidControll : MonoBehaviour
{

    public float speedY;
    public int damage;

    gameManager gm;
    GameObject obj;

    void Start()
    {
        obj = GameObject.Find("gameManager");
        gm = (gameManager)obj.GetComponent(typeof(gameManager));
    }

    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * speedY * Time.deltaTime);
		/*GetComponent<Rigidbody2D>().gravityScale = 0.55f;*/ 
		if (gm.timer >= 10f) { speedY = 1.02f; }
		if (gm.timer >= 20f) { speedY = 1.04f; }
		if (gm.timer >= 30f) { speedY = 1.06f; }
		if (gm.timer >= 40f) { speedY = 1.08f; }
		if (gm.timer >= 50f) { speedY = 1.1f; }
		if (gm.timer >= 60f) { speedY = 1.12f;}
		if (gm.timer >= 70f) { speedY = 1.14f; }
		if (gm.timer >= 80f) { speedY = 1.16f; }
		if (gm.timer >= 90f) { speedY = 1.18f; }
		if (gm.timer >= 100f) { speedY = 1.2f; }
		if (gm.timer >= 110f) { speedY = 1.22f; }
		if (gm.timer >= 120f) { speedY = 1.24f; }
		if (gm.timer >= 130f) { speedY = 1.26f; }
		if (gm.timer >= 140f) { speedY = 1.28f; }
		if (gm.timer >= 150f) { speedY = 1.3f;GetComponent<Rigidbody2D>().gravityScale = 0.5f; }
		if (gm.timer >= 160f) { speedY = 1.32f;GetComponent<Rigidbody2D>().gravityScale = 0.55f; }
		if (gm.timer >= 170f) { speedY = 1.34f;GetComponent<Rigidbody2D>().gravityScale = 0.6f; }
		if (gm.timer >= 180f) { speedY = 1.36f;GetComponent<Rigidbody2D>().gravityScale = 0.65f; }
		if (gm.timer >= 190f) { speedY = 1.38f;GetComponent<Rigidbody2D>().gravityScale = 0.7f; }
		if (gm.timer >= 200f) { speedY = 1.4f;GetComponent<Rigidbody2D>().gravityScale = 0.75f; }
		if (gm.timer >= 250f) { speedY = 1.42f;GetComponent<Rigidbody2D>().gravityScale = 0.8f; }
		if (gm.timer >= 500f) { speedY = 1.44f;GetComponent<Rigidbody2D>().gravityScale = 0.85f;}
		if (gm.timer >= 750f) { speedY = 1.46f;GetComponent<Rigidbody2D>().gravityScale = 0.9f; }
		if (gm.timer >= 1000f) { speedY = 1.47f;GetComponent<Rigidbody2D>().gravityScale = 0.95f; }
		if (gm.timer >= 1250f) { speedY = 1.5f;GetComponent<Rigidbody2D>().gravityScale = 1f; }
		if (gm.timer >= 1500f) { speedY = 1.75f;GetComponent<Rigidbody2D>().gravityScale = 1.1f; }
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "blockDestroy")

            Destroy(gameObject);
        
    }


}


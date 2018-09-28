using UnityEngine;
using System.Collections;

public class scrollBackground : MonoBehaviour
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
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;
        Vector2 offset = mat.mainTextureOffset;
        offset.y += Time.deltaTime * speed;
        mat.mainTextureOffset = offset;

        
		if (gm.timer >= 5f) { speed = 0.42f; }
		if (gm.timer >= 10f) { speed = 0.44f; }
		if (gm.timer >= 15f) { speed = 0.46f; }
		if (gm.timer >= 20f) { speed = 0.48f; }
		if (gm.timer >= 30f) { speed = 0.5f; }
		if (gm.timer >= 40f) { speed = 0.52f; }
		if (gm.timer >= 50f) { speed = 0.54f; }
		if (gm.timer >= 60f) { speed = 0.56f; }
		if (gm.timer >= 70f) { speed = 0.58f; } 
		if (gm.timer >= 80f) { speed = 0.6f; }
		if (gm.timer >= 90f) { speed = 0.62f; }
		if (gm.timer >= 100f) { speed = 0.64f; }
		if (gm.timer >= 110f) { speed = 0.66f; }
		if (gm.timer >= 120f) { speed = 0.68f; }
		if (gm.timer >= 130f) { speed = 0.7f; }
		if (gm.timer >= 140f) { speed = 0.72f; }
		if (gm.timer >= 150f) { speed = 0.74f; }
		if (gm.timer >= 160f) { speed = 0.76f; }
		if (gm.timer >= 170f) { speed = 0.78f; }
		if (gm.timer >= 180f) { speed = 0.8f; }
		if (gm.timer >= 190f) { speed = 0.82f; }
		if (gm.timer >= 200f) { speed = 0.84f; }
		if (gm.timer >= 250f) { speed = 0.9f; }
		if (gm.timer >= 300f) { speed = 0.95f; }
		if (gm.timer >= 400f) { speed = 1f; }
		if (gm.timer >= 500f) { speed = 1.03f; }
		if (gm.timer >= 600f) { speed = 1.06f; }
		if (gm.timer >= 700f) { speed = 1.09f; }
		if (gm.timer >= 800f) { speed = 1.12f; }
		if (gm.timer >= 900f) { speed = 1.15f; }
		if (gm.timer >= 1000f) { speed = 1.2f; }

    }



}
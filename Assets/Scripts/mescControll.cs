using UnityEngine;
using System.Collections;

public class mescControll : MonoBehaviour
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

        

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "blockDestroy1")

            Destroy(gameObject);
    }


}


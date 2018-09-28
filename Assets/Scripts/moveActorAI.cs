using UnityEngine;
using System.Collections;

public class moveActorAI : MonoBehaviour
{
    public float speedX;

    gameManager gm;
    GameObject obj;
    


    void Start()
    {
        obj = GameObject.Find("gameManager");
        gm = (gameManager)obj.GetComponent(typeof(gameManager));
    }

    public void Update()
    {
        Vector3 dir = Vector3.zero;
        dir.x = Input.acceleration.x;



        if (dir.sqrMagnitude > 1)
            dir.Normalize();
        transform.Translate(dir * speedX * Time.deltaTime);
    }
}
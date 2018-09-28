using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class moveShield : MonoBehaviour
{
    public float speedX;
    public float speedY;




    void Start()
    {
    }

    public void Update()
    {
        Vector3 dir = Vector3.zero;
        dir.x = Input.acceleration.x;
        //dir.y = Input.acceleration.y;



        if (dir.sqrMagnitude > 1)
            dir.Normalize();
        transform.Translate(dir * speedX * Time.deltaTime);
        //transform.Translate(dir * speedY * Time.deltaTime);

        

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "blockDestroy")

            Destroy(gameObject);
    }
}
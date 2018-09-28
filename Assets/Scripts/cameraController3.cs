using UnityEngine;
using System.Collections;

public class cameraController3 : MonoBehaviour {

    [SerializeField]
    private float xMax;

    /*[SerializeField]
    private float yMax;*/

    [SerializeField]
    private float xMin;

    /*[SerializeField]
    private float yMin;*/

    public Transform target;

    void start()
    {
        target = GameObject.Find("actor").transform;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x, xMin, xMax), transform.position.y, transform.position.z);
    }

    
}

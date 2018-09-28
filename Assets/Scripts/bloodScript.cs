using UnityEngine;
using System.Collections;

public class bloodScript : MonoBehaviour
{

	public float speed;



	void Update()
	{
		transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);

	}



}

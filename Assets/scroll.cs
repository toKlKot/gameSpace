using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour
{

	public float speed;

	void Start()
	{

	}

	void Update()
	{
		MeshRenderer mr = GetComponent<MeshRenderer>();
		Material mat = mr.material;
		Vector2 offset = mat.mainTextureOffset;
		offset.y += Time.deltaTime * speed;
		mat.mainTextureOffset = offset;

	}



}
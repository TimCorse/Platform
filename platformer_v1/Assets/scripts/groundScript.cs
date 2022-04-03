using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundScript : MonoBehaviour {

	// Эти значения появятся в Editor,
	// а заполненные свойства - нет
	public float Speed = 1;


	// Use this for initialization
	void Start()
	{
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + new Vector3(-Speed * Time.deltaTime, 0, 0);
	}
}

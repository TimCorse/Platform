using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {
	public float JumpSpeed = 1.5f;
	public Rigidbody2D rb2D;
	bool grounded = false;
	public Transform groundCheck;
	public float groundRadius = 0.1f;

	public LayerMask whatIsGround;
	// Use this for initialization
	void Awake()
	{
	}
	void Start ()
	{
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "dieCollider")
			Application.LoadLevel(Application.loadedLevel);
	}
	void FixedUpdate()
	{
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

	}
	// Update is called once per frame
	void Update () {

		if (grounded && Input.GetKeyDown(KeyCode.W))
		{
			rb2D.AddForce(new Vector2(0f, JumpSpeed), ForceMode2D.Impulse);
		}
		if (Input.GetKeyDown(KeyCode.R))
			Application.LoadLevel(Application.loadedLevel); 
	}
}

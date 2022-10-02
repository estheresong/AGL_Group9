using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public GameObject player;
	public Rigidbody rb;

	public float speed = .1f;
	public float jumpSpeed = 1f;

	Vector3 moveDirection;
	Vector3 lookRotate;	

	bool isGround;

	void Start() 
	{
		isGround = false;
	}	

    // Update is called once per frame
    void Update()
    {
		moveDirection.x = Input.GetAxisRaw("Horizontal");
		if (Input.GetButtonDown("Jump"))
		{
			Debug.Log("Jump Registered");
			Jump();
		}
    }

	void FixedUpdate()
	{
		rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);
	}

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == "Platform")
		{
			Debug.Log("isGrounded");
			isGround = true;
		}
		else
		{
			isGround = false;
		}
	}

	void Jump()
	{
		if (isGround)
		{
			float jumpVelocity = jumpSpeed * Time.fixedDeltaTime;
			rb.velocity = new Vector3( 0, jumpVelocity, 0);
			isGround = false;
			Debug.Log("jump");
		}
	}
}

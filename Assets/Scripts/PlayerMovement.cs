using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public GameObject player;
	public Rigidbody rb;
	public CapsuleCollider collider;

	public float speed = .1f;
	public float jumpSpeed = 1f;

	Vector3 moveDirection;
	Vector3 lookRotate;	

	bool isGround;
	bool isCrouch;
	bool lookLeft;
	bool lookRight;

	void Start() 
	{
		isGround = false;
		isCrouch = false;
	}	

    // Update is called once per frame
    void Update()
    {
		moveDirection.x = Input.GetAxisRaw("Horizontal");
		if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
		{
			lookLeft = true;
		} 
		else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
		{
			lookRight = true;
		}
		if (Input.GetButtonDown("Jump"))
		{
			Debug.Log("Jump Registered");
			Jump();
		}
		if (Input.GetKeyDown(KeyCode.LeftControl))
		{
			Debug.Log("Crouch Registered");
			Crouch();
		}
    }

	void FixedUpdate()
	{
		rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);
		if (lookLeft)
		{
			rb.rotation = Quaternion.Euler(0,180,0);
			lookLeft = false;
		}
		else if (lookRight)
		{
			rb.rotation = Quaternion.Euler(0,0,0);
			lookRight = false;
		}
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

	void Crouch()
	{
		if (isCrouch)
		{
			collider.height = 2;
			isCrouch = false;
		}
		else
		{
			collider.height = 1;
			isCrouch = true;
			if (isGround) {
				rb.AddForce(Vector3.down * 5f, ForceMode.Impulse);
			}
		}
	}
}

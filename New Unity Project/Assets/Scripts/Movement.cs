using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float gravity;
	public float speed;
	public float jumpHeight;
	public float afterJumpUpForce;
	public float afterJumpDownForce;

	public bool jumped = false;


	public Vector2 velocity;

	public bool move = true;

	public AudioClip jump;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(move){
			velocity = rigidbody2D.velocity;
			float horizontalMovement = Input.GetAxis("Horizontal")*speed;
			if(horizontalMovement<0 && this.transform.localScale.x>0)
				Flip();
			if(horizontalMovement>0 && this.transform.localScale.x<0)
				Flip();
			float verticalMovement = 0.0f;
			if(Input.GetAxis("Jump")>0&&!jumped){
				verticalMovement = Mathf.Sqrt (afterJumpUpForce * jumpHeight * -gravity);
				jumped = true;
				source.PlayOneShot(jump);
			}
			if(Input.GetAxis("Jump")<=0&&jumped){
				verticalMovement -= Mathf.Sqrt (afterJumpDownForce * jumpHeight);
			}
			velocity.x = horizontalMovement*speed;
			velocity.y += verticalMovement;
			rigidbody2D.velocity = velocity;
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		ContactPoint2D[] contacts = col.contacts;
		foreach(ContactPoint2D contact in contacts){
			if (contact.normal.y >= 0.8f){
				jumped = false;
				return;
			}
			else
				continue;
		}
	}

	void Flip(){
		this.transform.localScale = new Vector3(-this.transform.localScale.x,this.transform.localScale.y,this.transform.localScale.z);
	}
}

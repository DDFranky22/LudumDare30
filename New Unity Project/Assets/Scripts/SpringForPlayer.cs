using UnityEngine;
using System.Collections;

public class SpringForPlayer : MonoBehaviour {

	public float force;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.collider.CompareTag("Player"))
			col.rigidbody.velocity += new Vector2(0.0f,force);
	}

}

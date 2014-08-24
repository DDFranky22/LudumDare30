using UnityEngine;
using System.Collections;

public class AttachToMovementPlatform : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionStay2D(Collision2D col){
		if(col.collider.CompareTag("MovingPlatform")){
			this.gameObject.transform.parent = col.gameObject.transform;
		}
	}

	void OnCollisionExit2D(Collision2D col){
		this.gameObject.transform.parent = null;
	}
}

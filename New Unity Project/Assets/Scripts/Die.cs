using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {

	public ManageCheckpoints manager;

	private AudioSource source;
	public AudioClip die;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D c){
		if(c.collider.CompareTag("Death")){
			source.PlayOneShot(die);
			Vector3 position = manager.Respawn();
			this.transform.position = position;
		}
	}
}

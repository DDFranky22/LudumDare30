using UnityEngine;
using System.Collections;

public class CollectData : MonoBehaviour {

	public int DataCollected;

	public AudioClip pickUp;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		DataCollected = 0;
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.collider.CompareTag("Data")){
			DataCollected++;
			Destroy(col.gameObject);
			source.PlayOneShot(pickUp);
		}
	}

}

using UnityEngine;
using System.Collections;

public class enableDisableAtTime : MonoBehaviour {

	public float time;

	private SpriteRenderer render;
	private BoxCollider2D box;

	public AudioClip clip;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		render = GetComponent<SpriteRenderer>();
		box = GetComponent<BoxCollider2D>();
		source = GetComponent<AudioSource>();
		StartCoroutine(Active());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Active(){
		while(true){
			yield return new WaitForSeconds(time);
			render.enabled = true;
			box.enabled = true;
			source.PlayOneShot(clip);
			yield return new WaitForSeconds(time);
			render.enabled = false;
			box.enabled = false;
		}
	}

}

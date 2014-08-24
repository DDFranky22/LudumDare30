using UnityEngine;
using System.Collections;

public class PressButton : MonoBehaviour {

	public bool pressed;
	private Animator anim;

	private AudioSource source;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator WaitXSeconds(){
		yield return new WaitForSeconds(0.5f);
		anim.SetBool("Pressed",false);
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.collider.CompareTag("Player")){
			pressed = !pressed;
			anim.SetBool("Pressed",true);
			source.Play();
			StartCoroutine(WaitXSeconds());
		}
	}
}

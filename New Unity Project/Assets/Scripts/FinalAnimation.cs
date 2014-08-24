using UnityEngine;
using System.Collections;

public class FinalAnimation : MonoBehaviour {

	public bool StartAnim;
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(StartAnim){
			animator.SetBool("Final",true);
		}
	}
}

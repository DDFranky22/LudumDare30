using UnityEngine;
using System.Collections;

public class ChangeColorWhenButtonXPressed : MonoBehaviour {

	public PressButton x;
	private SpriteRenderer render;

	// Use this for initialization
	void Start () {
		render = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(x.pressed){
			render.color = Color.green;
		}
		else
			render.color =  Color.red;
	}
}

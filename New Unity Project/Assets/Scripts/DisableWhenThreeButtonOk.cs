using UnityEngine;
using System.Collections;

public class DisableWhenThreeButtonOk : MonoBehaviour {

	public PressButton[] buttons;

	private bool enable = true;
	private SpriteRenderer render;
	private BoxCollider2D box;
	public int i = 0;
	// Use this for initialization
	void Start () {
		render = GetComponent<SpriteRenderer>();
		box = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		i = 0;
		foreach(PressButton b in buttons){
			if(b.pressed){
				i++;
			}
		}
		if(i>2)
			enable = false;
		else
			enable = true;

		EnableObject(enable);
	}

	void EnableObject(bool v){
		if(!v){
			render.enabled = false;
			box.enabled = false;
		}
		else{
			render.enabled = true;
			box.enabled = true;
		}
	}
}

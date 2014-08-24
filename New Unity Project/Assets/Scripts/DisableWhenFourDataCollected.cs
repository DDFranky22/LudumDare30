using UnityEngine;
using System.Collections;

public class DisableWhenFourDataCollected : MonoBehaviour {

	public CollectData collectData;

	private SpriteRenderer render;
	private BoxCollider2D box;
	// Use this for initialization
	void Start () {
		render = GetComponent<SpriteRenderer>();
		box = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(collectData.DataCollected==4)
			Disable();
	}

	void Disable(){
		render.enabled = false;
		box.enabled = false;
	}

}

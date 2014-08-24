using UnityEngine;
using System.Collections;

public class ControlCamera : MonoBehaviour {

	private FinalAnimation controls;
	// Use this for initialization
	void Start () {
		controls = Camera.main.GetComponent<FinalAnimation>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D col){
		controls.StartAnim = true;
	}
}

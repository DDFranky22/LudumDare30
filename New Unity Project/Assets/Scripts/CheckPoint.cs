using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {

	public bool checkpoint;
	public ManageCheckpoints manager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.collider2D.CompareTag("Player")){
			checkpoint = true;
			manager.Submit(this.gameObject.GetComponent<CheckPoint>());
		}
	}
}

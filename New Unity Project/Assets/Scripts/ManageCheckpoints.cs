using UnityEngine;
using System.Collections;

public class ManageCheckpoints : MonoBehaviour {

	public CheckPoint[] checkpoints;

	// Use this for initialization
	void Start () {
	
	}

	public void Submit(CheckPoint c){
		for(int i = 0;i<checkpoints.Length;i++){
			if(checkpoints[i]!=c){
				checkpoints[i].checkpoint = false;
			}
		}
	}

	public Vector3 Respawn(){
		for(int i = 0;i<checkpoints.Length;i++){
			if(checkpoints[i].checkpoint){
				return checkpoints[i].gameObject.transform.position;
			}
		}
		return Vector3.zero;
	}

	// Update is called once per frame
	void Update () {
	
	}
}

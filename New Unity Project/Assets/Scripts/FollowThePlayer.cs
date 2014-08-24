using UnityEngine;
using System.Collections;

public class FollowThePlayer : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3(Player.transform.position.x,Player.transform.position.y -1.8f,-10.0f);
	}
}

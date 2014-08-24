using UnityEngine;
using System.Collections;

public class TriggerLastConversation : MonoBehaviour {

	public GameObject Conversation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		Conversation.SetActive(true);
	}

}

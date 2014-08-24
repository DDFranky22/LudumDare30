using UnityEngine;
using System.Collections;

public class EndingScore : MonoBehaviour {

	public bool good;
	public bool bad;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad(this.gameObject);
	}
}

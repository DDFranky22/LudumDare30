using UnityEngine;
using System.Collections;

public class Conversation : MonoBehaviour {

	public string[] conversation;
	private TextMesh text;

	public GameObject Choice1;
	public GameObject Choice2;

	public int i = 0;

	public bool theEnd;
	public bool cont = true;
	private Movement playerMovement;
	public EndingScore ending;


	public AudioClip clip;
	private AudioSource source;
	// Use this for initialization
	void Start () {
		text = GetComponent<TextMesh>();
		playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>();
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Return)){
			source.PlayOneShot(clip);
			if(i<conversation.Length-1)
				i++;
			if(i>=conversation.Length-1&&!theEnd){
				Choice1.SetActive(true);
				Choice2.SetActive(true);
				StartCoroutine(CheckSolution());
				theEnd = true;
				playerMovement.move = false;
				return;
			}
		}
		text.text = conversation[i];
	}

	IEnumerator CheckSolution(){
		while(cont){
			if(Input.GetKey(KeyCode.LeftArrow)){
				conversation[conversation.Length-1] = "...As you wish";
				ending.bad = true;
				ending.good = false;
				cont = false;
				yield return new WaitForSeconds(5.0f);
				Application.LoadLevel("FinalScene");
			}
			if(Input.GetKey(KeyCode.RightArrow)){
				conversation[conversation.Length-1] = "As you wish";
				ending.good = true;
				ending.bad = false;
				cont = false;
				yield return new WaitForSeconds(5.0f);
				Application.LoadLevel("FinalScene");
			}
			yield return new WaitForSeconds(0.1f);
		}
	}
}

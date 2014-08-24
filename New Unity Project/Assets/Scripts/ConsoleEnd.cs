using UnityEngine;
using System.Collections;

public class ConsoleEnd : MonoBehaviour {

	public string Text;
	public bool good;
	public bool bad;
	private EndingScore ending;
	// Use this for initialization
	void Start () {
		ending = GameObject.Find("Ending").GetComponent<EndingScore>();
		good = ending.good;
		bad = ending.bad;
		StartCoroutine(LastWords());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.Label(new Rect(0.0f,0.0f,Screen.width,Screen.height),Text);
	}

	IEnumerator LastWords(){
		if(good){
			Text += "_\n\r";
			yield return new WaitForSeconds(0.5f);
			Text += " \n\r";
			yield return new WaitForSeconds(0.5f);
			Text += "_\n\r";
			yield return new WaitForSeconds(0.5f);
			Text += " \n\r";
			yield return new WaitForSeconds(0.5f);
			Text += "_\n\r";
			yield return new WaitForSeconds(0.5f);
			Text += " \n\r";
			yield return new WaitForSeconds(0.5f);
			Text += "_\n\r";
			yield return new WaitForSeconds(0.5f);
			Text += " \n\r";
			yield return new WaitForSeconds(0.5f);
			Text += "A fatal error has occurred\n\r";
			Text += " \n\r";
			yield return new WaitForSeconds(3.0f);
			Text += "Reeboting System\n\r";
			yield return new WaitForSeconds(3.0f);
			Text += "Reeboting System.\n\r";
			yield return new WaitForSeconds(3.0f);
			Text += "Reeboting System..\n\r";
			yield return new WaitForSeconds(3.0f);
			Text += "Boot.ini not found\n\r";
			yield return new WaitForSeconds(5.0f);
			Destroy(ending.gameObject);
			//Application.LoadLevel ("FirstScene");
			Application.ExternalEval(
				"window.close();"
				);
		}
		if(bad){
			Text+= "_\n\r";
			yield return new WaitForSeconds(0.5f);
			Text += " \n\r";
			yield return new WaitForSeconds(0.5f);
			Text += "_\n\r";
			yield return new WaitForSeconds(0.5f);
			Text += " \n\r";
			yield return new WaitForSeconds(0.5f);
			Text += "_\n\r";
			yield return new WaitForSeconds(0.5f);
			Text += " \n\r";
			yield return new WaitForSeconds(0.5f);
			Text += "_\n\r";
			yield return new WaitForSeconds(0.5f);
			Text += " \n\r";
			yield return new WaitForSeconds(0.5f);
			Text += "Program loaded\n\r";
			yield return new WaitForSeconds(4.0f);
			Text += "Launching missiles in: 3\n\r";
			yield return new WaitForSeconds(1.0f);
			Text += "Launching missiles in: 2\n\r";
			yield return new WaitForSeconds(1.0f);
			Text += "Launching missiles in: 1\n\r";
			yield return new WaitForSeconds(1.0f);
			Text += "\n\r";
			yield return new WaitForSeconds(5.0f);
			Destroy(ending.gameObject);
			Application.LoadLevel ("FirstScene");
		}
	}
}

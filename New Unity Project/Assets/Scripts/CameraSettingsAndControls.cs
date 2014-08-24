using UnityEngine;
using System.Collections;

public class CameraSettingsAndControls : MonoBehaviour {

	public GameObject Player;

	public Vector2[] cameraPositions;
	public float[] size;
	public float speed;

	public bool FollowPlayer;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(FollowPlayer){
			this.transform.position = new Vector3(Player.transform.position.x,Player.transform.position.y-1.8f,-10.0f);
		}
	}

	IEnumerator changeSize(int s){
		float currentSize = Camera.main.orthographicSize;
		float changeToSize = size[s];
		float difference = currentSize-changeToSize;
		if(difference<0){
			print ("aumento");
			for(float i = currentSize;i<changeToSize;i+=-difference/60.0f){
				print (i);
				Camera.main.orthographicSize = i;
				if(i>=(changeToSize-1.0f))
					break;
				yield return (1.0f);
			}
		}
		else{
			print ("diminuisco");
			for(float i = currentSize;i>changeToSize;i-=difference/60.0f){
				Camera.main.orthographicSize = i;
				if(i<=(changeToSize+1.0f))
					break;
				yield return (1.0f);
			}
		}
	}

	public void ZoomTo(int position, int size){
		transform.Translate(new Vector3(cameraPositions[position].x,cameraPositions[position].y,-10.0f)*speed*Time.deltaTime);
		StopCoroutine("changeSize");
		StartCoroutine(changeSize(size));
	}
}

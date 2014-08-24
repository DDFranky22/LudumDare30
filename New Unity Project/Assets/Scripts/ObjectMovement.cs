using UnityEngine;
using System.Collections;

public class ObjectMovement : MonoBehaviour {

	public Vector2[] Path;
	public Vector2 Goal;
	public float speedMovement;

	private int i;

	// Use this for initialization
	void Start () {
		Path[0] = this.transform.position;
		Goal = Path[0];
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position == new Vector3(Goal.x,Goal.y,0.0f)){
			i++;
			if(i>Path.Length-1)
				i= 0;
			Goal = Path[i];
		}
		transform.position = Vector2.MoveTowards(transform.position, Goal, Time.deltaTime*speedMovement);
	}
}

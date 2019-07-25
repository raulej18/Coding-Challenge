using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		FaceMouse ();
	}

	private void FaceMouse(){
		Vector3 mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);

		Vector2 direction = new Vector2 (mousePosition.x-transform.position.x,mousePosition.y-transform.position.y);

		transform.up = direction;

	}
}

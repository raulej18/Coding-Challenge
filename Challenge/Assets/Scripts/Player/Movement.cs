using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	private int speed=4;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x=Input.GetAxis("Horizontal");
		float y=Input.GetAxis ("Vertical");
		transform.Translate (new Vector3 (speed*x*Time.deltaTime, speed*y*Time.deltaTime, 0));
	}
}

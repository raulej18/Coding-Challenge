using UnityEngine;
using System.Collections;

public class Bullet1 : MonoBehaviour {
	private int speed=15;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up*speed*Time.deltaTime);
		Destroy (gameObject, 1.5f);
	}
}

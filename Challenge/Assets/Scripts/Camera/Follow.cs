using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {
	public Transform playerTransform;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(playerTransform.position.x,playerTransform.position.y,transform.position.z);	
	}
}

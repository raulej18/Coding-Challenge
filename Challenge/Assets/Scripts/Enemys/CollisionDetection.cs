using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour {
	private Transform positionW;
	private Transform positionE;
	// Use this for initialization
	void Start () {
	
	}


	public Transform GetPositionW(){
		return positionW;
	}
	public Transform GetPositionE(){
		return positionE;
	}
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Weapon") {
			positionE = other.GetComponent<Transform> ();
		} else if (other.tag == "Ene" || other.name == "Soldier") {
			positionW=other.GetComponent<Transform>();		
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Weapon") {
			positionE = null;
		} else if (other.tag == "Ene" || other.name == "Soldier") {
			positionW=null;		
		}

	}
}

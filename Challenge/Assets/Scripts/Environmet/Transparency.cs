using UnityEngine;
using System.Collections;

public class Transparency : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "Soldier") {
			GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 0.5f);


		} else if (other.tag == "Ene") {
			GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 0.5f);
		}

	}

	void OnTriggerExit2D(Collider2D other){
		GetComponent<SpriteRenderer>().color=new Color(1,1,1,1);
	}
}

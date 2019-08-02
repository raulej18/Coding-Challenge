using UnityEngine;
using System.Collections;

public class hShield : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.name=="Soldier"){
			other.GetComponent<ControlPowers>().ActivatePowers("shield");
		}
		else if(other.tag=="Ene"){
			other.GetComponent<ControlPowersEne>().ActivatePowers("shield");
		}
	}
}

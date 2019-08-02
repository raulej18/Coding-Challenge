using UnityEngine;
using System.Collections;

public class hHealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay2D(Collider2D other){
		if(other.name=="Soldier"){
			other.GetComponent<ControlPowers>().ActivatePowers("health");
		}
		else if(other.tag=="Ene"){
			other.GetComponent<ControlPowersEne>().ActivatePowers("health");
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if(other.name=="Soldier"){
			other.GetComponent<ControlPowers>().ActivatePowers("");
		}
		else if(other.tag=="Ene"){
			other.GetComponent<ControlPowersEne>().ActivatePowers("health");
		}
	}
}

using UnityEngine;
using System.Collections;

public class Weapon1 : MonoBehaviour {
	private PlaceWeapon position;
	// Use this for initialization
	void Start () {
		position=GameObject.Find ("Weapon").GetComponent<PlaceWeapon>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.name == "Soldier") {
			if(position.GetItIsCharged()){
				if(position.ReturnCurrentWeapon().name!="Pistol(Clone)(Clone)"){
					Destroy (position.ReturnCurrentWeapon());
					position.CreateWeapon (gameObject);
					Destroy (gameObject);
				}
				
				
			}
			else{
				position.CreateWeapon (gameObject);
				Destroy (gameObject);
			}
			
		} 
	}
}

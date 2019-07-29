using UnityEngine;
using System.Collections;

public class Weapon3 : MonoBehaviour {
	private PlaceWeapon position;
	private bool inUse;
	// Use this for initialization
	void Start () {
		position=GameObject.Find ("Weapon").GetComponent<PlaceWeapon>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public bool GetInUse(){
		return inUse;
	}

	public void SetInUse(bool value){
		inUse = value;
	}
	void OnTriggerEnter2D(Collider2D other){
		if (!inUse) {
			if (other.name == "Soldier") {
				if (position.GetItIsCharged ()) {
					if (position.ReturnCurrentWeapon ().name != "Bazooka(Clone)(Clone)") {
						Destroy (position.ReturnCurrentWeapon ());
						position.CreateWeapon (gameObject);
						Destroy(gameObject);
					}
					
					
				} else {
					
					position.CreateWeapon (gameObject);
					Destroy(gameObject);
				}
				
			} else if (other.tag== "Ene") {
				other.GetComponent<AttackEne> ().CreateWeapon (gameObject);
				Destroy(gameObject);
			}
			
		}
	}
}

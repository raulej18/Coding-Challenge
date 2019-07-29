using UnityEngine;
using System.Collections;

public class Weapon2 : MonoBehaviour {
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

	void OnTriggerEnter2D(Collider2D other){

		if (other.name == "Soldier") {
			if(position.GetItIsCharged()){
				if(position.ReturnCurrentWeapon().name!="MachineGun(Clone)(Clone)"){
					Destroy (position.ReturnCurrentWeapon());
					inUse=true;
					position.CreateWeapon (gameObject);
					Destroy (gameObject);
				}


			}
			else{
				inUse=true;
				position.CreateWeapon (gameObject);
				Destroy (gameObject);
			}

		}

	}
}

using UnityEngine;
using System.Collections;

public class Weapon1 : MonoBehaviour {
	private PlaceWeapon position;
	private Generator gene;

	// Use this for initialization
	void Start () {
		position=GameObject.Find ("Weapon").GetComponent<PlaceWeapon>();

	}
	
	// Update is called once per frame
	void Update () {

	}
<<<<<<< HEAD
	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "Soldier") {
			if (position.GetItIsCharged ()) {
				if (position.ReturnCurrentWeapon ().name != "Pistol(Clone)") {
					Destroy (position.ReturnCurrentWeapon ());
					position.CreateWeapon (gameObject);
					NewPosition();
				}
				
				
			} else {
				
				position.CreateWeapon (gameObject);
				NewPosition ();
			}
			
		} else if (other.tag == "Ene") {
			if(!other.GetComponent<AttackEne>().GetCharged()){
				other.GetComponent<AttackEne>().createWeapon(gameObject);
				NewPosition();
			}
		}

	}
	private void NewPosition(){
		int x = Random.Range (2,48);
		int y = Random.Range (2, 48);
		transform.position = new Vector3 (x,y,transform.position.z);
=======
	public bool GetInUse(){
		return inUse;
	}
	void OnTriggerEnter2D(Collider2D other){

		if (other.name == "Soldier") {
			if(position.GetItIsCharged()){
				if(position.ReturnCurrentWeapon().name!="Pistol(Clone)(Clone)"){
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

>>>>>>> parent of 16fd046... ShootSolved
	}
}

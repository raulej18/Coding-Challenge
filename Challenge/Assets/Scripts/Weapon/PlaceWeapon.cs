using UnityEngine;
using System.Collections;

public class PlaceWeapon : MonoBehaviour {
	private bool itIsCharged;
	private Transform positionFire;
	private string nameWeapon;

	public GameObject bullet1;
	public GameObject bullet2;
	private GameObject bulletSelected;

	private float time;
	private float speedBullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}


	public void CreateWeapon(GameObject w){
		GameObject weapon=Instantiate(w,transform.position,transform.parent.rotation)as GameObject;
		weapon.transform.parent=transform;
		itIsCharged=true;
		nameWeapon=transform.GetChild(0).name;
		positionFire=transform.GetChild(0).GetChild(0).transform;
		if (nameWeapon == "Pistol(Clone)(Clone)") {
			bulletSelected=bullet1;
			speedBullet = 0.3f;	
		} else if (nameWeapon == "MachineGun(Clone)(Clone)") {
			bulletSelected=bullet1;
			speedBullet = 0.1f;
		} else if (nameWeapon == "Bazooka(Clone)(Clone)") {
			speedBullet=0.2f;
			bulletSelected=bullet2;
		}

	}
	public bool GetItIsCharged(){
		return itIsCharged;

	}
	public void shot(){
		if(time<speedBullet){
			time+=Time.deltaTime;
		}
		else{
			time=0;
			GameObject b=Instantiate(bulletSelected,positionFire.position,transform.parent.rotation)as GameObject;
		}

	}
}

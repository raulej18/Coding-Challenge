using UnityEngine;
using System.Collections;

public class PlaceWeapon : MonoBehaviour {
	private bool itIsCharged;
	private Transform positionFire;
	private string nameWeapon;
	private GameObject currentWeapon;

	public GameObject bullet1;
	public GameObject bullet2;
	private GameObject bulletSelected;


	private float time;
	private float timeWeapon;
	private float speedBullet;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(itIsCharged){
			if(timeWeapon<5){
				timeWeapon+=Time.deltaTime;

			}
			else{
				timeWeapon=0;
				Destroy(currentWeapon);
				itIsCharged=false;
			}
		}
	}


	public void CreateWeapon(GameObject w){
		GameObject weapon=Instantiate(w,transform.position,transform.parent.rotation)as GameObject;
		currentWeapon = weapon;
		weapon.transform.parent=transform;
		itIsCharged=true;
		nameWeapon=weapon.name;
		positionFire=weapon.GetComponent<Transform>().GetChild(0).transform;
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
	public GameObject ReturnCurrentWeapon(){
		return  currentWeapon;
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

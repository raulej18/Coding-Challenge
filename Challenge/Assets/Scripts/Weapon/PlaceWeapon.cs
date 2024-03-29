﻿using UnityEngine;
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
			if(timeWeapon<15){
				timeWeapon+=Time.deltaTime;

			}
			else{
				timeWeapon=0;
				Destroy(currentWeapon);
				itIsCharged=false;
			}
		}
	}


	public void CreateWeapon(GameObject wGenerate){
		GameObject weapon=Instantiate(wGenerate,transform.position,transform.parent.rotation)as GameObject;
		currentWeapon = weapon;
		weapon.transform.parent=transform;
		itIsCharged=true;
		nameWeapon=weapon.name;
		positionFire=weapon.GetComponent<Transform>().GetChild(0).transform;
		if (nameWeapon == "Pistol(Clone)(Clone)") {
			bulletSelected=bullet1;
			speedBullet = 0.3f;	
			currentWeapon.GetComponent<w1>().SetInUse(true);

			
		} else if (currentWeapon.name == "MachineGun(Clone)(Clone)") {
			bulletSelected=bullet1;
			speedBullet = 0.1f;
			currentWeapon.GetComponent<w2>().SetInUse(true);
			
		} else if (currentWeapon.name == "Bazooka(Clone)(Clone)") {
			speedBullet=0.2f;
			bulletSelected=bullet2;
			currentWeapon.GetComponent<w3>().SetInUse(true);
		}
		weapon.transform.parent=transform;
		itIsCharged=true;
		positionFire=weapon.GetComponent<Transform>().GetChild(0).transform;



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
			b.GetComponent<BulletDamage>().setNameBullet("Soldier");
		}

	}
}

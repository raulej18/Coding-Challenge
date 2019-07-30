using UnityEngine;
using System.Collections;

public class AttackEne : MonoBehaviour {
	private GameObject[] bullets;

	private bool charged;
	private GameObject currentWeapon;
	private Transform bulletPosition;
	private float time;

	private float shootTime;
	private float speedShoot;
	private GameObject bulletW;



	void Start(){
		bullets = GameObject.Find ("Weapon Generator").GetComponent<Bullets> ().GetBullets ();


	}

	void Update(){
		if(charged){
			ControlLife();
			ShootWeapon();

		}
	}
	public bool IsCharged(){
		return charged;
	}

	private void ShootWeapon(){
		if(shootTime<speedShoot){
			shootTime+=Time.deltaTime;
			
		}
		else{
			shootTime=0;
			bulletPosition=currentWeapon.transform.GetChild(0);
			GameObject bullet=Instantiate(bulletW,bulletPosition.position,bulletPosition.rotation)as GameObject;
		}

	}

	private void ControlLife(){
		if(time<5){
			time+=Time.deltaTime;
			
			
		}
		else{
			time=0;
			charged=false;
			Destroy(currentWeapon);
			
		}
	}


	public void CreateWeapon(GameObject wGenerate){
		GameObject arma=Instantiate(wGenerate,transform.GetChild(0).position,transform.rotation)as GameObject;
		arma.transform.parent=transform.GetChild(0);
		currentWeapon=arma;
		charged=true;
		if(currentWeapon.name=="Bazooka(Clone)(Clone)"){
			speedShoot=0.2f;
			bulletW=bullets[1];
			currentWeapon.GetComponent<w3>().SetInUse(true);
		}
		else if(currentWeapon.name=="MachineGun(Clone)(Clone)"){
			speedShoot=0.1f;
			bulletW=bullets[0];
			currentWeapon.GetComponent<w2>().SetInUse(true);
		}
		else{
			speedShoot=0.3f;
			bulletW=bullets[0];
			currentWeapon.GetComponent<w1>().SetInUse(true);
		}
	}




}

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

	private SearchWeaponAndEne position;

	void Start(){
		bullets=new GameObject[2];
		bullets=GameObject.Find("EnemyGenerator").GetComponent<Bullets>().GetBullets();
		position=transform.GetChild(0).GetComponent<SearchWeaponAndEne>();

	}

	void Update(){
		if(charged){
			if(currentWeapon==null){

			}
			else{
			}
			if(shootTime<speedShoot){
				shootTime+=Time.deltaTime;
				
			}
			else{
				shootTime=0;
				ShootWeapon();
			}

			if(time<5){
				time+=Time.deltaTime;


			}
			else{
				time=0;
				charged=false;
				Destroy(currentWeapon);

			}
		}
	}
	public bool IsCharged(){
		return charged;
	}
	private void ShootWeapon(){
		bulletPosition=currentWeapon.transform.GetChild(0);
		GameObject bullet=Instantiate(bulletW,bulletPosition.position,bulletPosition.rotation)as GameObject;


	}

	void OnTriggerEnter2D(Collider2D other){
		if(!charged&&other.tag=="Weapon"){
			GameObject arma=Instantiate(other.gameObject,transform.GetChild(0).position,transform.rotation)as GameObject;
			arma.transform.parent=transform.GetChild(0);
			currentWeapon=arma;
			currentWeapon.tag = "Untagged";
			charged=true;
			if(currentWeapon.name=="Bazooka(Clone)(Clone)"){
				speedShoot=0.2f;
				bulletW=bullets[1];
			}
			else if(currentWeapon.name=="MachineGun(Clone)(Clone)"){
				speedShoot=0.1f;
				bulletW=bullets[0];
			}
			else{
				speedShoot=0.3f;
				bulletW=bullets[0];
			}

		}
	}




}

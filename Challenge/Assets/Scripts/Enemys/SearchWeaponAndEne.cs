using UnityEngine;
using System.Collections;

public class SearchWeaponAndEne : MonoBehaviour {

	private Transform direction;
	private AttackEne attack;
	private MovEnemy mov;

	private float timeWait;
	private bool lock1;
	private bool lock2;

	void Start(){
		attack=GetComponentInParent<AttackEne>();
		mov=GetComponentInParent<MovEnemy>();
	}
	void Update(){
		if(timeWait<3){
			timeWait+=Time.deltaTime;
			if(direction!=null){
				mov.UpdatePosition(direction);
			}



		}
		else{
			mov.GenerateDirection();
			timeWait=0;
			lock1=false;
			lock2=false;
		}


	}



	void OnTriggerEnter2D(Collider2D other){
		if(attack.IsCharged()){
			if(!lock2&&(other.name=="Soldier"||other.tag=="Ene")){
				direction=other.transform;
				lock2=true;
			}
		}
		else{
			if(lock1&&(other.tag=="Weapon")){
				direction=other.transform;
				lock1=true;
			}
		}
	}
}

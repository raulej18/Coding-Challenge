using UnityEngine;
using System.Collections;

public class PlaceWeapon : MonoBehaviour {
	private bool itIsCharged;
	private Transform positionFire;
	private string nameWeapon;
	public GameObject bullet1;

	private float time;
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

	}
	public bool GetItIsCharged(){
		return itIsCharged;

	}
	public void shot(){
		if(nameWeapon=="Pistol(Clone)(Clone)"){
			if(time<0.3f){
				time+=Time.deltaTime;
			}
			else{
				time=0;
				GameObject b=Instantiate(bullet1,positionFire.position,transform.parent.rotation)as GameObject;
			}

		}

	}
}

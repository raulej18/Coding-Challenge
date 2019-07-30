﻿using UnityEngine;
using System.Collections;

public class w1 : MonoBehaviour {
	private bool inUse;
	private PlaceWeapon place;
	// Use this for initialization
	void Start () {
		place=GameObject.Find("Soldier").GetComponentInChildren<PlaceWeapon>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void SetInUse(bool value){
		inUse = value;
	}
	public bool GetInUse(){
		return inUse;
	}


	void OnTriggerEnter2D(Collider2D other){
		if (!inUse) {
			if (other.name == "Soldier") {
				if (!place.GetItIsCharged ()) {
					place.CreateWeapon (gameObject);
					ChangePosition ();
				}
			} else if (other.tag == "Ene") {
				if (!other.GetComponent<AttackEne> ().IsCharged ()) {
					other.GetComponent<AttackEne> ().CreateWeapon (gameObject);
					ChangePosition ();
				}
			}
		}

	}

	private void ChangePosition(){
		int x = Random.Range (2,48);
		int y = Random.Range (2, 48);
		transform.position = new Vector3 (x,y,transform.position.z);
	}

}

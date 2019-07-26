﻿using UnityEngine;
using System.Collections;

public class Weapon2 : MonoBehaviour {
	private PlaceWeapon position;
	// Use this for initialization
	void Start () {
		position=GameObject.Find ("Weapon").GetComponent<PlaceWeapon>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other){
		
		if(other.name=="Soldier"&&!position.GetItIsCharged()){
			position.CreateWeapon(gameObject);
			Destroy (gameObject);
		}
	}
}
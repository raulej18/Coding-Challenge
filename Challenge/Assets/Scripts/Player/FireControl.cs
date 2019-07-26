using UnityEngine;
using System.Collections;

public class FireControl : MonoBehaviour {

	public PlaceWeapon charged;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(charged.GetItIsCharged()){
			if(Input.GetMouseButton(0)){
				charged.shot();

			}
			else{

			}
		}

	}


}

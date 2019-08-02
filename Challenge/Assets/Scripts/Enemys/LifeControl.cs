using UnityEngine;
using System.Collections;

public class LifeControl : MonoBehaviour {
	private int life;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (life <= 0) {
			ChangeDirection();
		}
	}

	private void ChangeDirection(){
		
	}



	public void TODamage(int damage){
		life -= damage;
	}
}

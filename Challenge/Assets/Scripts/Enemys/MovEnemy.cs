using UnityEngine;
using System.Collections;

public class MovEnemy : MonoBehaviour {
	private float speed=3.5f;

	private Vector2 direction;
	private bool directionUpdate;
	private int changeTime;
	private float time;

	// Use this for initialization
	void Start () {

			

	}
	
	// Update is called once per frame
	void Update () {
		if (!directionUpdate) {
			GenerateDirection();
		} 
		else {
			transform.Translate(Vector3.up*speed*Time.deltaTime);
			if(time<changeTime){
				time+=Time.deltaTime;

			}
			else{
				time=0;
				directionUpdate=false;
			}
		}

	}
	private void GenerateDirection(){
		direction = new Vector2 (Random.Range (10, 140), Random.Range (10, 140));
		Vector2 aux = direction;
		aux= new Vector2 (aux.x-transform.position.x,aux.y-transform.position.y);
		transform.up = aux;
		directionUpdate = true;
		changeTime = Random.Range (3,20);
	}
}

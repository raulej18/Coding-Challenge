using UnityEngine;
using System.Collections;

public class MovEnemy : MonoBehaviour {
	private float speed=3.5f;


	private Vector2 direction;
	private Vector2 direction2;
	private bool directionUpdate;
	private int changeTime;
	private float time;


	private SearchWeaponAndEne position;



	// Use this for initialization
	void Start () {
		position=transform.GetChild(0).GetComponent<SearchWeaponAndEne>();


	}
	
	// Update is called once per frame
	void Update () {
		if (!directionUpdate) {
			GenerateDirection();
		} 
		else {
			if(time<changeTime){
				time+=Time.deltaTime;
				transform.Translate(Vector3.up*speed*Time.deltaTime);
				
			}
			else{
				time=0;
				directionUpdate=false;
			}
		}



	}

	public void UpdatePosition(Transform pos){
		Vector2 aux = pos.position;
		aux= new Vector2 (aux.x-transform.position.x,aux.y-transform.position.y);
		transform.up = aux;
	}
	public void GenerateDirection(){
		direction = new Vector2 (Random.Range (10, 140), Random.Range (10, 140));
		Vector2 aux = direction;
		aux= new Vector2 (aux.x-transform.position.x,aux.y-transform.position.y);
		transform.up = aux;
		directionUpdate = true;
		changeTime = Random.Range (3,20);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag=="Extremo"){
			GenerateDirection();
		}	
	}
}

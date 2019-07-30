using UnityEngine;
using System.Collections;

public class MovEnemy : MonoBehaviour {
	private float speed=3.5f;


	private Vector2 direction;
	private Vector2 direction2;
	private int changeTime;
	private float time;

	private AttackEne attack;
	public CollisionDetection col;
	private float timeAttack;


	// Use this for initialization
	void Start () {
		attack = GetComponent<AttackEne> ();
		GenerateDirection();
	}
	
	// Update is called once per frame
	void Update () {

		if (attack.IsCharged()) {
			if(timeAttack<2){
				timeAttack+=Time.deltaTime;
				transform.Translate(Vector3.up*speed*Time.deltaTime);
			}
			else{
				timeAttack=0;
				if(col.GetPositionE()!=null){
					time=0;
					UpdatePosition(col.GetPositionE().position);
				}
				else{
					GenerateDirection();
				}
			}
		} 
		else {
			if(time<changeTime){
				time+=Time.deltaTime;
				transform.Translate(Vector3.up*speed*Time.deltaTime);
				
			}
			else{
				time=0;
				if(col.GetPositionW()!=null){
					time=0;
					UpdatePosition(col.GetPositionW().position);
				}
				else{
					GenerateDirection();
				}

			}
		}



	}


	public void UpdatePosition(Vector3 pos){
		Vector2 aux = pos;
		aux= new Vector2 (aux.x-transform.position.x,aux.y-transform.position.y);
		transform.up = aux;
	}
	public void GenerateDirection(){
		direction = new Vector2 (Random.Range (10, 140), Random.Range (10, 140));
		Vector2 aux = direction;
		aux= new Vector2 (aux.x-transform.position.x,aux.y-transform.position.y);
		transform.up = aux;
		changeTime = Random.Range (3,20);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag=="Extremo"){
			GenerateDirection();
		}	
	}
}

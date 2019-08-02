using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeEnemy : MonoBehaviour {

	private int life=100;

	private bool hit;
	private float time=0;

	private bool isDead;

	public Transform bar;

	private string nameBullet="";
	private CountKills textkills;



	// Use this for initialization
	void Start () {
		textkills=GameObject.Find("TextKills").GetComponent<CountKills>();
	}
	
	// Update is called once per frame
	void Update () {
		if(life<=0){
			ChangePosition();
			isDead=true;
			life=100;
			bar.localPosition=new Vector3(0,0,0);
			bar.localScale=new Vector3(1,1,1);
			if(nameBullet.Equals("Soldier")){
				textkills.IncrementCount();

			}
		}
		if(hit){
			if(time<0.09f){
				time+=Time.deltaTime;
			}
			else{
				time=0;
				hit=false;
				GetComponent<SpriteRenderer>().color=Color.white;
			}
		}
	}
	public int GetLife(){
		return life;
	}
	public void AddLife(int value){
		life+=value;
	}
	public bool GetIsDead(){
		return isDead;
	}
	private void ChangePosition(){
		int x = Random.Range (10,140);
		int y = Random.Range (10, 140);
		transform.position = new Vector3 (x,y,transform.position.z);
	}
	
	public void ToDamage(int damage ){
		life-=damage;
		hit=true;
		GetComponent<SpriteRenderer>().color=Color.red;
		float currentDamage=(float)damage/100;
		bar.localPosition=new Vector3(bar.localPosition.x-(currentDamage*2),0,0);
		bar.localScale=new Vector3(bar.localScale.x-currentDamage,1,1);
	}
	public void SetNameBullet(string name){
		nameBullet=name;
	}

}

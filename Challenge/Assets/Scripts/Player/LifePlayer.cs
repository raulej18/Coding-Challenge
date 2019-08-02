using UnityEngine;
using System.Collections;

public class LifePlayer : MonoBehaviour {
	private int life=100;

	private bool hit;
	private float time=0;

	public Transform bar;
	public GameObject panelDead;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(life<=0){
			panelDead.SetActive(true);
			Time.timeScale=0;
			Destroy (gameObject);
		}
		if(hit){
			if(time<0.09f){
				time+=Time.deltaTime;
			}
			else{
				time=0;
				hit=false;
				transform.GetChild(0).GetComponent<SpriteRenderer>().color=Color.white;
			}
		}
	}
	public int GetLife(){
		return life;
	}
	public void AddLife(int value){
		life+=value;
	}
	public void ToDamage(int damage ){
		life-=damage;
		hit=true;
		transform.GetChild(0).GetComponent<SpriteRenderer>().color=Color.red;
		float currentDamage=(float)damage/100;
		bar.localPosition=new Vector3(bar.localPosition.x-(currentDamage*2),0,0);
		bar.localScale=new Vector3(bar.localScale.x-currentDamage,1,1);


	}
}

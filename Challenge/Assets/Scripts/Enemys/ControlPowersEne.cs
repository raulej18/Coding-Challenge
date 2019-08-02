using UnityEngine;
using System.Collections;

public class ControlPowersEne : MonoBehaviour {
	public GameObject shield;
	public Transform health;
	private LifeEnemy life;
	
	private string namePower="";
	
	private float timeActivated;
	
	// Use this for initialization
	void Start () {
		life=GetComponent<LifeEnemy>();
	}


	// Update is called once per frame
	void Update () {
		if(namePower.Equals("shield")){
			if(timeActivated<10){
				timeActivated+=Time.deltaTime;
			}
			else{
				timeActivated=0;
				shield.SetActive(false);
				namePower="";
			}
		}
		else if(namePower.Equals ("health")){
			if(timeActivated<0.5f){
				timeActivated+=Time.deltaTime;
			}
			else{
				if(life.GetLife()<100){
					timeActivated=0;
					health.localPosition=new Vector3(health.localPosition.x+(0.1f*2),0,0);
					health.localScale=new Vector3(health.localScale.x+0.1f,1,1);
					life.AddLife(10);
				}
				
			}
			
			
		}
	}
	public bool ShieldIsActivate(){
		return shield.activeInHierarchy;
	}
	public void ActivatePowers(string name){
		if(name.Equals("shield")){
			if(!shield.activeInHierarchy){
				shield.SetActive(true);
			}
		}
		namePower=name;
	}
}

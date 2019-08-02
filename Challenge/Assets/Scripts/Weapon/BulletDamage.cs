using UnityEngine;
using System.Collections;

public class BulletDamage : MonoBehaviour {
	private int damage;
	private string nameBullet="";
	// Use this for initialization
	void Start () {
		if(gameObject.name=="BulletBazooka(Clone)"){
			damage=20;
		}
		else{
			damage=5;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void setNameBullet(string name){
		nameBullet=name;
	}
	public string GetNameBullet(){
		return nameBullet;
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.name=="Soldier"){
			if(!other.GetComponent<ControlPowers>().ShieldIsActivate()){
				other.GetComponent<LifePlayer>().ToDamage(damage);
			}

			Destroy (gameObject);
		}
		else if(other.tag=="Ene"){
			if(!other.GetComponent<ControlPowersEne>().ShieldIsActivate()){
				other.GetComponent<LifeEnemy>().ToDamage(damage);
				if(nameBullet.Equals("Soldier")){
					other.GetComponent<LifeEnemy>().SetNameBullet(nameBullet);
				}
			}

			Destroy(gameObject);
		}

	}
}

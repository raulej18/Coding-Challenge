using UnityEngine;
using System.Collections;

public class GenerateTerrain : MonoBehaviour {
	public GameObject base1;
	public GameObject base2;
	// Use this for initialization
	void Start () {
		Generator ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void Generator(){
		for (int i=0; i<50; i++) {
			for(int j=0;j<50;j++){
				if(j==0||i==0||j==49||i==49){
					CreateBase(base2,i,j);
				}
				else{
					CreateBase(base1,i,j);
				}
			}
		}

	}

	private void CreateBase(GameObject b,int i,int j){
		GameObject baseP=Instantiate(b,new Vector3(i*3,j*3,0),Quaternion.identity)as GameObject;
		baseP.transform.parent = transform;

	}
}

using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {
	public GameObject[] generates;
	public int[] mount;
	public int total;
	// Use this for initialization
	void Start () {
		GenerateObjects();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void GenerateObjects(){
		for (int i=0; i<total; i++) {
			if(i<mount[0]){
				Generate (generates[0]);
			}
			else if(i<mount[1]){
				Generate (generates[1]);
			}
			else if(i<mount[2]){
				Generate (generates[2]);
			}
			else if(i<mount[3]){
				Generate (generates[3]);
			}
			else {
				Generate (generates[4]);
			}
		}
	}
	private void Generate(GameObject b){
		int x = Random.Range (1,49);
		int y = Random.Range (1, 49);
		GameObject baseP=Instantiate(b,new Vector3((x*3)+2,(y*3)+2,-3),Quaternion.identity)as GameObject;
		baseP.transform.parent = transform;
	}




}

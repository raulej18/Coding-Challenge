using UnityEngine;
using System.Collections;

public class GTreeAndBuilding : MonoBehaviour {
	public GameObject[] generates;
	public int[] mount;
	public int total;

	private int i;

	private int[] posX;
	private int[] posY;
	private int countX;
	private int countY;

	// Use this for initialization
	void Start () {
		posX = posY= new int[48];
		countX = countY = 0;
		i = 0;
		GenerateObjects();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void GenerateObjects(){
		while(i<total) {
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
				Generate(generates[3]);
			}
			else {
				Generate (generates[4]);
			}
			i++;
		}
	}
	private void Generate(GameObject b){
		int x = Random.Range (1,49);
		int y = Random.Range (1, 49);
		if (RepeatedPosition (x, y)) {
			Generate (b);
		} 
		else {
			GameObject baseP=Instantiate(b,new Vector3(x*3,y*3,-2),Quaternion.identity)as GameObject;
			baseP.transform.parent = transform;
			posX[countX]=x;
			posY[countY]=y;
		}


	}
	private bool RepeatedPosition(int x, int y){
		for (int i=0; i<posX.Length; i++) {
			if(posX[i]!=0){
				if(posX[i]==x && posY[i]==y){
					return true;
				}

			}
			else{
				return false;
			}
		}
		return false;
	}

}

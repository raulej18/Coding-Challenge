using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CountKills : MonoBehaviour {
	int count;
	public HighScore hScore;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void IncrementCount(){
		count++;
		GetComponent<Text>().text="Kills:"+count;
		hScore.UpdateHighScore(count);
	}

}

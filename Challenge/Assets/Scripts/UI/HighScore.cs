using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HighScore : MonoBehaviour {
	public Text highScore;

	// Use this for initialization
	void Start () {
		highScore.text="HighScore:"+PlayerPrefs.GetInt("HighScore",0).ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void UpdateHighScore(int count){
		PlayerPrefs.SetInt("HighScore",count);
	}


}

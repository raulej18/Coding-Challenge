using UnityEngine;
using System.Collections;

public class ButtonPlayAgain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ClickOnPlayAgain(){
		Application.LoadLevel(0);
	}
}

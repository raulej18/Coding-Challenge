using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ButtonPlay : MonoBehaviour {
	public GameObject panelName;
	public TextMesh playerName;
	public Text textName;
	
	// Use this for initialization
	void Start () {
		Time.timeScale=0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ClickOnPlay(){
		Time.timeScale=1;
		playerName.text="Player:"+textName.text;
		Destroy (panelName);
	}
}

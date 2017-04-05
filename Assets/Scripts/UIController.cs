using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

	// Use this for initialization
	void Start() {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameHandler.Instance._playerUI.GetComponent<RectTransform>().anchoredPosition=new Vector2(-Screen.width/2+(Screen.width/3.5f),
			-Screen.height/2+(Screen.height/3.5f));
		GameHandler.Instance._designerUI.GetComponent<RectTransform>().anchoredPosition=new Vector2(Screen.width/2-Screen.width/3f,
			Screen.height/2-Screen.height/2.5f);
		GameHandler.Instance._followBall.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (-Screen.width/2 + Screen.width / 10,
			Screen.height/2 - Screen.height / 10 - 50);
		GameHandler.Instance._changeCam.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (-Screen.width/2 + Screen.width / 10,
			Screen.height/2 - Screen.height / 10);
	}
}

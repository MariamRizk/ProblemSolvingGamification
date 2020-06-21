using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitHinitBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InputField txtBoxInput = gameObject.GetComponent<InputField>();
		Debug.Log(txtBoxInput);

		txtBoxInput.text = "xE6wEU5ydL46oV3b6ADwRkMkX4smED7sVr4NeaqrRFY";
	}
	
	// Update is called once per frame
	void Update () {
	}
}


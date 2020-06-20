using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosetInitMsg : MonoBehaviour {
	// Use this for initialization
	void Start () {
		InputField txtBoxInput = gameObject.GetComponent<InputField>();
		Debug.Log(txtBoxInput);

		txtBoxInput.text = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9";
	}
	
	// Update is called once per frame
	void Update () {
	}
}

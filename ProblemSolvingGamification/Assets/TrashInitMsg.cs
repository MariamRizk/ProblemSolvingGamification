using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashInitMsg : MonoBehaviour {
	// Use this for initialization
	void Start () {
		InputField txtBoxInput = gameObject.GetComponent<InputField>();
		Debug.Log(txtBoxInput);

		txtBoxInput.text = "eyJ1c2VybmFtZSI6IkRlYWRIYWNrZXIiLCJwYXNzd29yZCI6InNoZXJsb2NrZWQifQ";
	}
	
	// Update is called once per frame
	void Update () {
	}
}

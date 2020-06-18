using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitHinitBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InputField txtBoxInput = gameObject.GetComponent<InputField>();
		Debug.Log(txtBoxInput);

		txtBoxInput.text = "dGhlIGxhcmdlc3QgcHJpbWUgZmFjdG9yIG9mIHRoZSBudW1iZXIgNjAwODUxNDc1";
	}
	
	// Update is called once per frame
	void Update () {
	}
}

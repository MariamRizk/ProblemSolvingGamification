using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AcceptInput : MonoBehaviour {
	public GameObject invlidPasswordText;
	public InputField laptopInputField;
	const string correctPassword = "sherlocked";

	// Use this for initialization
	void Start () {
		var btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(HandleInput);
	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator HideInvlidPasswordMessage()
	{
		Debug.Log("Start count down to hide the invalid password");
		yield return new WaitForSeconds(5);
		invlidPasswordText.SetActive(false);
	}

	void HandleInput()
	{
		string password = laptopInputField.text;
		if (password == correctPassword){
			Debug.Log("correct password. must load email scene");
			invlidPasswordText.SetActive(false);
			SceneManager.LoadScene("EmailScene");
		}
		else {
			Debug.Log("Invlid Password");
			invlidPasswordText.SetActive(true);
			StartCoroutine(HideInvlidPasswordMessage());
		}

	}
}

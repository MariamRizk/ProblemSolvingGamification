using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintOnClick : MonoBehaviour {
	
	public GameObject hintComponent;

	// Use this for initialization
	void Start () {
		var btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(OnClick);
	}

	void OnClick()
	{
		hintComponent.SetActive(true);
	}
}
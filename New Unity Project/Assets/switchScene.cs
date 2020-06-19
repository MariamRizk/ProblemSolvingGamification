using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class switchScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("HEEEEEEEEEEEEEEEEEEEEEEEEEEEY");
		// Thread.Sleep(20000);
		SceneManager.LoadScene("Scene2");

	}
}

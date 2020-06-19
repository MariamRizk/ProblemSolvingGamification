using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTrashPuzzel : MonoBehaviour {
	public Camera Player;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Player = Camera.main;
		Vector3 pos = Player.transform.position;
		Collider collider = gameObject.GetComponent<Collider>();
		if (collider.bounds.Contains(pos) && Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene("TrashPuzzle");
		}
	}
}

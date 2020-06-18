using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetDoorInteraction : MonoBehaviour {

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //Any condition we want
        if (Input.GetKey(KeyCode.O))
        {
            animator.SetTrigger("open");
            animator.ResetTrigger("close");
        }

        if (Input.GetKey(KeyCode.C))
        {
            animator.ResetTrigger("open");
            animator.SetTrigger("close");
        }

    }
}

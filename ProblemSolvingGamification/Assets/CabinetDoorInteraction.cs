using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetDoorInteraction : MonoBehaviour {

	Animator animator;
    Collider cabinetCollider;
    Camera player;
    static bool isOpened = false;

	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator>();
        cabinetCollider = gameObject.GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
        player = Camera.main;
        Vector3 playerPos = player.transform.position;

        Debug.Log("inside:" + cabinetCollider.bounds.Contains(playerPos).ToString());
        Debug.Log("opened:" + isOpened.ToString());
        Debug.Log("pressed:" + Input.GetKey(KeyCode.E).ToString());
        if (cabinetCollider.bounds.Contains(playerPos) && isOpened == false && Input.GetKey(KeyCode.E))
        {
            Debug.Log("shouldExecuteAnimation");
            animator.SetTrigger("open");
            animator.ResetTrigger("close");
            isOpened = true;
        }

        else if (cabinetCollider.bounds.Contains(playerPos) && isOpened == true && Input.GetKey(KeyCode.E))
        {
            animator.ResetTrigger("open");
            animator.SetTrigger("close");
            isOpened = false;
        }
    }
}

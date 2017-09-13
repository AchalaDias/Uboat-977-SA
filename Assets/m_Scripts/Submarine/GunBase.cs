using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBase : MonoBehaviour {

	float cmaRayLength = 10000f;
	int aimLayer;

	void Awake () {
		aimLayer = LayerMask.GetMask ("Aim");
	}


	void Update(){
		
		Turning ();
	}

	void Turning(){
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if(Physics.Raycast(camRay, out hit, cmaRayLength, aimLayer)){
			Vector3 playerToMouse = hit.point;
			if(playerToMouse.y < 0){
				playerToMouse.y = 0f;
			}
			transform.LookAt (playerToMouse);

		}
			
	}
}

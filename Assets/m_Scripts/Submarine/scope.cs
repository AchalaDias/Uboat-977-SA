using UnityEngine;

namespace Ceto
{
public class scope : MonoBehaviour {

	public GameObject scopeOverlay;
	private bool isScoped = false;

	public GameObject mainCam;
	public GameObject scopeCamEnd;
	private Vector3 mainCamPosition;

	[Range(10.0f, 50.0f)]
	public float scopZoom = 50.0f;


	void Start () {
		 
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.N)){
			isScoped = !isScoped;
				mainCam.GetComponent<ShipCamera> ().isScoped = isScoped;
			scopeOverlay.SetActive (isScoped);
		}
		keepChangingCamPosition ();
	}

    // changing the main camera position for every frame inorder to move the scope view with submarine
	void keepChangingCamPosition(){
			if(isScoped){
				mainCamPosition = new Vector3 (scopeCamEnd.transform.position.x ,scopeCamEnd.transform.position.y,scopeCamEnd.transform.position.z);
				mainCam.GetComponent<ShipCamera> ().scopePosition =  mainCamPosition;	
				Camera.main.fieldOfView = scopZoom;
			}
	}
}
}

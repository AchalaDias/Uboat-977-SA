
using UnityEngine;
namespace Ceto{

public class SubmarineUpDown : MonoBehaviour {

	void Start () {
		
	}

	void Update () {

		if(Ocean.Instance == null) return;

		Vector3 pos = transform.position;

		 if(Input.GetKey(KeyCode.UpArrow)){
				pos.y += 0.04f;

				if(pos.y >= -0.5f){
					pos.y = -0.5f;
				}
			}
			if(Input.GetKey(KeyCode.DownArrow)){
				pos.y -= 0.04f;

				if(pos.y <= -70.0f){
					pos.y = -70.0f;
				}
			}

		transform.position = pos;

		
	}
}
}

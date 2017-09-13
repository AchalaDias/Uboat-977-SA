using UnityEngine;

public class BackgroundAudioHander : MonoBehaviour {

	public AudioSource m_underWaterSound;
	public AudioSource m_sonaSound;
	public AudioClip m_underWater;
	public AudioClip m_sona;
	public AudioClip m_ocean;

	bool isPlayedUnderWater = false;
	bool isPlayedOcean = false;

	void Start () {
		
	}
	

	void Update () {
		Vector3 camPosition =  Camera.main.gameObject.transform.position;
		if (camPosition.y < 0.0f) {
			if(!isPlayedUnderWater){
				m_underWaterSound.clip = m_underWater;
				m_sonaSound.clip = m_sona;
				m_sonaSound.Play ();
				m_underWaterSound.Play ();
				isPlayedUnderWater = true;
				isPlayedOcean = false;
			}

		} else {
			
			if(!isPlayedOcean){
				m_sonaSound.Stop ();
				m_underWaterSound.clip = m_ocean;
				m_underWaterSound.Play ();
				isPlayedUnderWater = false;
				isPlayedOcean = true;
			}

		}
	}
}

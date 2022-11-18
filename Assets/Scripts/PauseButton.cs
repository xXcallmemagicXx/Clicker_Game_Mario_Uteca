using UnityEngine;
using System.Collections;

public class PauseButton : MonoBehaviour {

	float currentTimeScale;

	public GameObject pauseMenu;

	
	void Start () {
		currentTimeScale = Time.timeScale;
		pauseMenu.SetActive (false);
	}
	
	
	void Update () {
	
	}


	public void Pressed(){
		if (Time.timeScale == 0) {
			Time.timeScale = currentTimeScale;
			pauseMenu.SetActive (false);
		} else {
			Time.timeScale = 0;
			pauseMenu.SetActive (true);
		}


	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonHandle: MonoBehaviour{
	// Load Scan Target
	public void StartButton(){
		SceneManager.LoadScene("arScene");
	}

	// Load Main Menu
	public void BackButton(){
		SceneManager.LoadScene("uiScene");
	}

	// Exit Application
	public void ExitButton(){	
		Application.Quit();
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public void PlayMaze()
	{
		SceneManager.LoadScene(1);
	}

	public void QuitMaze()
	{
		Debug.Log("Quit Game");
		
		Application.Quit();
	}
}

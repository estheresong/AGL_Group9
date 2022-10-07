using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
	public static bool isGameOver = false;

	public GameObject gameOverUI;

	public void GameOver()
	{
		gameOverUI.SetActive(true);
		Time.timeScale = 0f;
		isGameOver = true;
	}
	
	public void TryAgain()
	{
		Debug.Log("Restart");
		Time.timeScale = 1f;
		isGameOver = false;
		//SceneManager.LoadScene("Test_Enviroment");
	}	
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool GameHasEnded = false;
	public float DelayTime = 1.5f;
	public float DelayTimeLvl = 5f;

	public GameObject LCUI;

	public void CompleteLevel ()
	{
		LCUI.SetActive(true);
		Invoke("NextLevel", DelayTimeLvl);
	}

	public void NextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}


	public void EndGame()
	{
		if (GameHasEnded == false)
		{
			GameHasEnded = true;
			Invoke("Restart", DelayTime);
		}
	}

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}

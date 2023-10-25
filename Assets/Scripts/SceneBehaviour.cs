using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	private int sceneNum = 0;


	#region Public Method

	public void SetPlayScene(int sceneNum_)
	{
		sceneNum = sceneNum_;
	}


	public void PlayMainScene()
	{
		SceneManager.LoadScene("MainScene");
	}


	public void ChangeScene()
	{
		switch (sceneNum)
		{
			case 0:
				SceneManager.LoadScene("ElevenMetersScene");
				break;

			case 1:
				SceneManager.LoadScene("TwentyFiveMetersScene");
				break;

			case 2:
				SceneManager.LoadScene("FourtyMetersScene");
				break;
		}
	}

	public void ReloadScene(int _sceneNum)
	{
		SceneManager.LoadScene(_sceneNum);
	}

	#endregion
}

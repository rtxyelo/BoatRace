using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
	private string _currentBoatKey = "CurrentBoat";
	private string _currentLevelKey = "CurrentLevel";
	// Start is called before the first frame update
	void Start()
	{
		if (!PlayerPrefs.HasKey(_currentBoatKey))
		{
			PlayerPrefs.SetInt(_currentBoatKey, 0);
		}
		if (!PlayerPrefs.HasKey(_currentLevelKey))
		{
			PlayerPrefs.SetInt(_currentLevelKey, 0);
		}
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void LoadGameScene(string sceneName)
	{
		switch (sceneName)
		{
			case "EasyGamePlayScene":
				PlayerPrefs.SetInt(_currentLevelKey, 0);
				break;
			case "NormalGamePlayScene":
				PlayerPrefs.SetInt(_currentLevelKey, 1);
				break;
			case "MediumGamePlayScene":
				PlayerPrefs.SetInt(_currentLevelKey, 2);
				break;
			case "HardGamePlayScene":
				PlayerPrefs.SetInt(_currentLevelKey, 3);
				break;
		}
		LoadScene(sceneName);
	}

	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}
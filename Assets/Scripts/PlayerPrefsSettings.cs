using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsSettings : MonoBehaviour
{
	public bool isReset = false;

	private string _currentBoatKey = "CurrentBoat";
	private string _moneyCountKey = "MoneyCount";
	private string _hasNormalBoatKey = "HasNormalBoat";
	private string _hasMeduimBoatKey = "HasMediumBoat";
	private string _hasHardBoatKey = "HasHardBoat";
	private string _playerName = "PlayerName";
	private string _AchieveDate1 = "AchieveDate1";
	private string _AchieveDate2 = "AchieveDate2";
	private string _AchieveDate3 = "AchieveDate3";
	private string _AchieveDate4 = "AchieveDate4";
	private string _AchieveCurentDate = "AchieveCurentDate";
	private string _AchieveTime1 = "AchieveTime1";
	private string _AchieveTime2 = "AchieveTime2";
	private string _AchieveTime3 = "AchieveTime3";
	private string _AchieveTime4 = "AchieveTime4";
	private string _AchieveCurentTime = "AchieveCurentTime";

	// Start is called before the first frame update
	void Start()
    {
		if (!PlayerPrefs.HasKey(_currentBoatKey))
		{
			PlayerPrefs.SetInt(_currentBoatKey, 0);
		}
		if (!PlayerPrefs.HasKey(_moneyCountKey))
		{
			PlayerPrefs.SetInt(_moneyCountKey, 0);
		}
		if (!PlayerPrefs.HasKey(_hasNormalBoatKey))
		{
			PlayerPrefs.SetInt(_hasNormalBoatKey, 0);
		}
		if (!PlayerPrefs.HasKey(_hasMeduimBoatKey))
		{
			PlayerPrefs.SetInt(_hasMeduimBoatKey, 0);
		}
		if (!PlayerPrefs.HasKey(_hasHardBoatKey))
		{
			PlayerPrefs.SetInt(_hasHardBoatKey, 0);
		}
		if (!PlayerPrefs.HasKey(_playerName))
		{
			PlayerPrefs.SetString(_playerName, "Elvir");
		}
		if (!PlayerPrefs.HasKey(_AchieveDate1))
		{
			PlayerPrefs.SetString(_AchieveDate1, "19.10.2023");
		}
		if (!PlayerPrefs.HasKey(_AchieveDate2))
		{
			PlayerPrefs.SetString(_AchieveDate2, "19.10.2023");
		}
		if (!PlayerPrefs.HasKey(_AchieveDate3))
		{
			PlayerPrefs.SetString(_AchieveDate3, "19.10.2023");
		}
		if (!PlayerPrefs.HasKey(_AchieveDate4))
		{
			PlayerPrefs.SetString(_AchieveDate4, "19.10.2023");
		}
		if (!PlayerPrefs.HasKey(_AchieveCurentDate))
		{
			PlayerPrefs.SetString(_AchieveCurentDate, "19.10.2023");
		}
		if (!PlayerPrefs.HasKey(_AchieveTime1))
		{
			PlayerPrefs.SetInt(_AchieveTime1, 999);
		}
		if (!PlayerPrefs.HasKey(_AchieveTime2))
		{
			PlayerPrefs.SetInt(_AchieveTime2, 999);
		}
		if (!PlayerPrefs.HasKey(_AchieveTime3))
		{
			PlayerPrefs.SetInt(_AchieveTime3, 999);
		}
		if (!PlayerPrefs.HasKey(_AchieveTime4))
		{
			PlayerPrefs.SetInt(_AchieveTime4, 999);
		}
		if (!PlayerPrefs.HasKey(_AchieveCurentTime))
		{
			PlayerPrefs.SetInt(_AchieveCurentTime, 0);
		}

		if (isReset)
		{
			PlayerPrefs.SetInt(_currentBoatKey, 0);
			PlayerPrefs.SetInt(_moneyCountKey, 0);
			PlayerPrefs.SetInt(_hasNormalBoatKey, 0);
			PlayerPrefs.SetInt(_hasMeduimBoatKey, 0);
			PlayerPrefs.SetInt(_hasHardBoatKey, 0);
			PlayerPrefs.SetInt(_AchieveTime1, 999);
			PlayerPrefs.SetInt(_AchieveTime2, 999);
			PlayerPrefs.SetInt(_AchieveTime3, 999);
			PlayerPrefs.SetInt(_AchieveTime4, 999);
		}


		Debug.Log("currentBoat " + PlayerPrefs.GetInt(_currentBoatKey, 0));
		Debug.Log("moneyCount " + PlayerPrefs.GetInt(_moneyCountKey, 0));
		Debug.Log("_hasNormalBoat " + PlayerPrefs.GetInt(_hasNormalBoatKey, 0));
		Debug.Log("hasMeduimBoat " + PlayerPrefs.GetInt(_hasMeduimBoatKey, 0));
		Debug.Log("hasHardBoat " + PlayerPrefs.GetInt(_hasHardBoatKey, 0));
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsSettings : MonoBehaviour
{
	private string _currentBoatKey = "CurrentBoat";
	private string _moneyCountKey = "MoneyCount";
	private string _hasNormalBoatKey = "HasNormalBoat";
	private string _hasMeduimBoatKey = "HasMediumBoat";
	private string _hasHardBoatKey = "HasHardBoat";

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


		PlayerPrefs.SetInt(_currentBoatKey, 0);
		PlayerPrefs.SetInt(_moneyCountKey, 0);
		PlayerPrefs.SetInt(_hasNormalBoatKey, 0);
		PlayerPrefs.SetInt(_hasMeduimBoatKey, 0);
		PlayerPrefs.SetInt(_hasHardBoatKey, 0);


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

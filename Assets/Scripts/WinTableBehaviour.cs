using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class WinTableBehaviour : MonoBehaviour
{
    public GameObject Timer;
	public TMP_Text timerText;

	private float _time = -1;
    private TimerBehaviour _timerBehaviour;


	private string _playerName = "PlayerName";
	private string _AchieveDate1 = "AchieveDate1";
	private string _AchieveDate2 = "AchieveDate2";
	private string _AchieveDate3 = "AchieveDate3";
	private string _AchieveDate4 = "AchieveDate4";
	private string _AchieveTime1 = "AchieveTime1";
	private string _AchieveTime2 = "AchieveTime2";
	private string _AchieveTime3 = "AchieveTime3";
	private string _AchieveTime4 = "AchieveTime4";

	private int[] Times = new int[4];
	private string[] Dates = new string[4];

	// Start is called before the first frame update
	void Start()
    {
		_timerBehaviour = Timer.GetComponent<TimerBehaviour>();
		if (!Timer)
		{
			Timer = GameObject.Find("Timer");
		}

		Times[0] = PlayerPrefs.GetInt(_AchieveTime1, 999);
		Times[1] = PlayerPrefs.GetInt(_AchieveTime2, 999);
		Times[2] = PlayerPrefs.GetInt(_AchieveTime3, 999);
		Times[3] = PlayerPrefs.GetInt(_AchieveTime4, 999);

		Dates[0] = PlayerPrefs.GetString(_AchieveDate1, "19.10.2023");
		Dates[1] = PlayerPrefs.GetString(_AchieveDate2, "19.10.2023");
		Dates[2] = PlayerPrefs.GetString(_AchieveDate3, "19.10.2023");
		Dates[3] = PlayerPrefs.GetString(_AchieveDate4, "19.10.2023");
	}

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeInHierarchy && _time < 0)
        {
			_time = _timerBehaviour.time;
			timerText.text = "time " + ((int)_time).ToString() + "s";
			Timer.SetActive(false);
		}
    }

	public void WriteAchieve()
	{
		DateTime date = DateTime.Now;
		CheckTimes((int)_time, date.Day.ToString() + "." + date.Month.ToString() + "." + date.Year.ToString());
		for (int i = 1; i < Times.Length + 1; i++)
		{
			PlayerPrefs.SetInt("AchieveTime" + i, Times[i - 1]);
			PlayerPrefs.SetString("AchieveDate" + i, Dates[i - 1]);
		}
	}

	private void CheckTimes(int time, string date)
	{
		for (int i = 0; i < Times.Length; i++)
		{
			if (Times[i] > time)
			{
				int temp = Times[i];
				Times[i] = time;
				time = temp;

				string tempStr = Dates[i];
				Dates[i] = date;
				date = tempStr;
			}
		}
	}
}

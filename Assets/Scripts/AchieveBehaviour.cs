using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AchieveBehaviour : MonoBehaviour
{
	[SerializeField] private ChartBehaviour _chart1;
	[SerializeField] private ChartBehaviour _chart2;
	[SerializeField] private ChartBehaviour _chart3;
	[SerializeField] private ChartBehaviour _chart4;

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

	}

    // Update is called once per frame
    void Update()
    {
		
    }

	public void WriteCharts()
	{
		Times[0] = PlayerPrefs.GetInt(_AchieveTime1, 0);
		Times[1] = PlayerPrefs.GetInt(_AchieveTime2, 0);
		Times[2] = PlayerPrefs.GetInt(_AchieveTime3, 0);
		Times[3] = PlayerPrefs.GetInt(_AchieveTime4, 0);

		Dates[0] = PlayerPrefs.GetString(_AchieveDate1, "19.10.2023");
		Dates[1] = PlayerPrefs.GetString(_AchieveDate2, "19.10.2023");
		Dates[2] = PlayerPrefs.GetString(_AchieveDate3, "19.10.2023");
		Dates[3] = PlayerPrefs.GetString(_AchieveDate4, "19.10.2023");

		Debug.Log("Times0 " + Times[0]);

		_chart1.setFields("Elvir", Times[0], 1, Dates[0]);
		_chart2.setFields("Elvir", Times[1], 2, Dates[1]);
		_chart3.setFields("Elvir", Times[2], 3, Dates[2]);
		_chart4.setFields("Elvir", Times[3], 4, Dates[3]);
	}


}

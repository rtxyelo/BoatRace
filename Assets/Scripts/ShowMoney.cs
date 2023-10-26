using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ShowMoney : MonoBehaviour
{
	[SerializeField] private TMP_Text _moneyCountText;
	private string _moneyCountKey = "MoneyCount";

	// Start is called before the first frame update
	void Awake()
	{
		if (!PlayerPrefs.HasKey(_moneyCountKey))
		{
			PlayerPrefs.SetInt(_moneyCountKey, 0);
		}
		ShowMoneyFunc();
	}

	public void ShowMoneyFunc()
	{
		//PlayerPrefs.SetInt(_moneyCountKey, 0);
		_moneyCountText.text = $"$ {PlayerPrefs.GetInt(_moneyCountKey, 0)}";
	}
}

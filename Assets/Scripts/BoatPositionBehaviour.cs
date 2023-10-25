using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using System.Net;
using UnityEngine.SceneManagement;
using System.Drawing;
using System;

public class BoatPositionBehaviour : MonoBehaviour
{

    [SerializeField] private List<GameObject> _easyBoatsObj;
	[SerializeField] private List<RectTransform> _easyBoatsPositions;
	//[SerializeField] private List<GameObject> _normalBoatsObj;
	//[SerializeField] private List<RectTransform> _normalBoatsPositions;
	//[SerializeField] private List<GameObject> _mediumBoatsObj;
	//[SerializeField] private List<RectTransform> _mediumBoatsPositions;
	//[SerializeField] private List<GameObject> _hardBoatsObj;
	//[SerializeField] private List<RectTransform> _hardBoatsPositions;
	private List<Transform> _easyBoats = new List<Transform>();
	//private List<Transform> _normalBoats = new List<Transform>();
	//private List<Transform> _mediumBoats = new List<Transform>();
	//private List<Transform> _hardBoats = new List<Transform>();
	public void SetBoatPositionsByColor()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
			int[] _freePositions = { -1, -1, -1, -1};
			for (int i = 0; i <= 3; i++)
			{
				int _color;
				do
				{
					_color = UnityEngine.Random.Range(0, 3);
				}
				while (Array.Exists(_freePositions, element => element == _color));
				_freePositions[i] = _color;
				// Translate boat in position
				_easyBoatsObj[i].SetActive(true);
				_easyBoats[i].position = _easyBoatsPositions[i].position;
			}
		}
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {

        }
		else if (SceneManager.GetActiveScene().buildIndex == 3)
		{

		}
		else if (SceneManager.GetActiveScene().buildIndex == 4)
		{

		}
	}


	// Start is called before the first frame update
	void Start()
	{
		for (int i = 0; i <= 3; ++i)
		{
			_easyBoats[i] = _easyBoatsObj[i].GetComponent<Transform>();
			//_normalBoats[i] = _normalBoatsObj[i].GetComponent<Transform>();
			//_mediumBoats[i] = _mediumBoatsObj[i].GetComponent<Transform>();
			//_hardBoats[i] = _hardBoatsObj[i].GetComponent<Transform>();
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}

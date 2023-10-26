using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MediumBoatsPositionsBehaviour : MonoBehaviour
{

	[SerializeField] private GameObject _mediumBlackBoat;
	[SerializeField] private GameObject _mediumBlueBoat;
	[SerializeField] private GameObject _mediumRedBoat;
	[SerializeField] private GameObject _mediumYellowBoat;

	[SerializeField] private RectTransform _firstBoatPosition;
	[SerializeField] private RectTransform _secondBoatPosition;
	[SerializeField] private RectTransform _thirdBoatPosition;
	[SerializeField] private RectTransform _fourthBoatPosition;

	private Transform _mediumBlackBoatPosition;
	private Transform _mediumBlueBoatPosition;
	private Transform _mediumRedBoatPosition;
	private Transform _mediumYellowBoatPosition;


	private Dictionary<int, int[]> _positionVariations = new Dictionary<int, int[]>();

	// Start is called before the first frame update
	void Start()
	{
		_mediumBlackBoatPosition = _mediumBlackBoat.GetComponent<Transform>();
		_mediumBlueBoatPosition = _mediumBlueBoat.GetComponent<Transform>();
		_mediumRedBoatPosition = _mediumRedBoat.GetComponent<Transform>();
		_mediumYellowBoatPosition = _mediumYellowBoat.GetComponent<Transform>();


		for (int i = 0; i < 24; i++)
		{
			int[] variation = new int[] { i % 4, (i + 1) % 4, (i + 2) % 4, (i + 3) % 4 };
			_positionVariations[i] = variation;
		}

	}

	public void SetBoatPositionsByColor()
	{
		int colors = Random.Range(0, 24);
		//Debug.Log("colorsVariants " + colors);
		int[] _freePositions = _positionVariations[colors];
		//Debug.Log("_freePositions " + _freePositions[0] + " " + _freePositions[1] + " " + _freePositions[2] + " " + _freePositions[3]);


		switch (_freePositions[0])
		{
			case 0:
				_mediumBlackBoat.SetActive(true);
				_mediumBlackBoatPosition.position = _firstBoatPosition.position;
				break;
			case 1:
				_mediumBlueBoat.SetActive(true);
				_mediumBlueBoatPosition.position = _firstBoatPosition.position;
				break;
			case 2:
				_mediumRedBoat.SetActive(true);
				_mediumRedBoatPosition.position = _firstBoatPosition.position;
				break;
			case 3:
				_mediumYellowBoat.SetActive(true);
				_mediumYellowBoatPosition.position = _firstBoatPosition.position;
				break;
		}

		switch (_freePositions[1])
		{
			case 0:
				_mediumBlackBoat.SetActive(true);
				_mediumBlackBoatPosition.position = _secondBoatPosition.position;
				break;
			case 1:
				_mediumBlueBoat.SetActive(true);
				_mediumBlueBoatPosition.position = _secondBoatPosition.position;
				break;
			case 2:
				_mediumRedBoat.SetActive(true);
				_mediumRedBoatPosition.position = _secondBoatPosition.position;
				break;
			case 3:
				_mediumYellowBoat.SetActive(true);
				_mediumYellowBoatPosition.position = _secondBoatPosition.position;
				break;
		}

		switch (_freePositions[2])
		{
			case 0:
				_mediumBlackBoat.SetActive(true);
				_mediumBlackBoatPosition.position = _thirdBoatPosition.position;
				break;
			case 1:
				_mediumBlueBoat.SetActive(true);
				_mediumBlueBoatPosition.position = _thirdBoatPosition.position;
				break;
			case 2:
				_mediumRedBoat.SetActive(true);
				_mediumRedBoatPosition.position = _thirdBoatPosition.position;
				break;
			case 3:
				_mediumYellowBoat.SetActive(true);
				_mediumYellowBoatPosition.position = _thirdBoatPosition.position;
				break;
		}

		switch (_freePositions[3])
		{
			case 0:
				_mediumBlackBoat.SetActive(true);
				_mediumBlackBoatPosition.position = _fourthBoatPosition.position;
				break;
			case 1:
				_mediumBlueBoat.SetActive(true);
				_mediumBlueBoatPosition.position = _fourthBoatPosition.position;
				break;
			case 2:
				_mediumRedBoat.SetActive(true);
				_mediumRedBoatPosition.position = _fourthBoatPosition.position;
				break;
			case 3:
				_mediumYellowBoat.SetActive(true);
				_mediumYellowBoatPosition.position = _fourthBoatPosition.position;
				break;
		}
	}

}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardBoatsPositionsBehaviour : MonoBehaviour
{

	[SerializeField] private GameObject _hardBlackBoat;
	[SerializeField] private GameObject _hardBlueBoat;
	[SerializeField] private GameObject _hardRedBoat;
	[SerializeField] private GameObject _hardYellowBoat;

	[SerializeField] private RectTransform _firstBoatPosition;
	[SerializeField] private RectTransform _secondBoatPosition;
	[SerializeField] private RectTransform _thirdBoatPosition;
	[SerializeField] private RectTransform _fourthBoatPosition;

	private Transform _hardBlackBoatPosition;
	private Transform _hardBlueBoatPosition;
	private Transform _hardRedBoatPosition;
	private Transform _hardYellowBoatPosition;


	private Dictionary<int, int[]> _positionVariations = new Dictionary<int, int[]>();

	// Start is called before the first frame update
	void Start()
	{
		_hardBlackBoatPosition = _hardBlackBoat.GetComponent<Transform>();
		_hardBlueBoatPosition = _hardBlueBoat.GetComponent<Transform>();
		_hardRedBoatPosition = _hardRedBoat.GetComponent<Transform>();
		_hardYellowBoatPosition = _hardYellowBoat.GetComponent<Transform>();


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
				_hardBlackBoat.SetActive(true);
				_hardBlackBoatPosition.position = _firstBoatPosition.position;
				break;
			case 1:
				_hardBlueBoat.SetActive(true);
				_hardBlueBoatPosition.position = _firstBoatPosition.position;
				break;
			case 2:
				_hardRedBoat.SetActive(true);
				_hardRedBoatPosition.position = _firstBoatPosition.position;
				break;
			case 3:
				_hardYellowBoat.SetActive(true);
				_hardYellowBoatPosition.position = _firstBoatPosition.position;
				break;
		}

		switch (_freePositions[1])
		{
			case 0:
				_hardBlackBoat.SetActive(true);
				_hardBlackBoatPosition.position = _secondBoatPosition.position;
				break;
			case 1:
				_hardBlueBoat.SetActive(true);
				_hardBlueBoatPosition.position = _secondBoatPosition.position;
				break;
			case 2:
				_hardRedBoat.SetActive(true);
				_hardRedBoatPosition.position = _secondBoatPosition.position;
				break;
			case 3:
				_hardYellowBoat.SetActive(true);
				_hardYellowBoatPosition.position = _secondBoatPosition.position;
				break;
		}

		switch (_freePositions[2])
		{
			case 0:
				_hardBlackBoat.SetActive(true);
				_hardBlackBoatPosition.position = _thirdBoatPosition.position;
				break;
			case 1:
				_hardBlueBoat.SetActive(true);
				_hardBlueBoatPosition.position = _thirdBoatPosition.position;
				break;
			case 2:
				_hardRedBoat.SetActive(true);
				_hardRedBoatPosition.position = _thirdBoatPosition.position;
				break;
			case 3:
				_hardYellowBoat.SetActive(true);
				_hardYellowBoatPosition.position = _thirdBoatPosition.position;
				break;
		}

		switch (_freePositions[3])
		{
			case 0:
				_hardBlackBoat.SetActive(true);
				_hardBlackBoatPosition.position = _fourthBoatPosition.position;
				break;
			case 1:
				_hardBlueBoat.SetActive(true);
				_hardBlueBoatPosition.position = _fourthBoatPosition.position;
				break;
			case 2:
				_hardRedBoat.SetActive(true);
				_hardRedBoatPosition.position = _fourthBoatPosition.position;
				break;
			case 3:
				_hardYellowBoat.SetActive(true);
				_hardYellowBoatPosition.position = _fourthBoatPosition.position;
				break;
		}
	}

}

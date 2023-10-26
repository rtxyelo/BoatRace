using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalBoatsPositionsBehaviour : MonoBehaviour
{

	[SerializeField] private GameObject _normalBlackBoat;
	[SerializeField] private GameObject _normalBlueBoat;
	[SerializeField] private GameObject _normalRedBoat;
	[SerializeField] private GameObject _normalYellowBoat;

	[SerializeField] private RectTransform _firstBoatPosition;
	[SerializeField] private RectTransform _secondBoatPosition;
	[SerializeField] private RectTransform _thirdBoatPosition;
	[SerializeField] private RectTransform _fourthBoatPosition;

	private Transform _normalBlackBoatPosition;
	private Transform _normalBlueBoatPosition;
	private Transform _normalRedBoatPosition;
	private Transform _normalYellowBoatPosition;


	private Dictionary<int, int[]> _positionVariations = new Dictionary<int, int[]>();

	// Start is called before the first frame update
	void Start()
	{
		_normalBlackBoatPosition = _normalBlackBoat.GetComponent<Transform>();
		_normalBlueBoatPosition = _normalBlueBoat.GetComponent<Transform>();
		_normalRedBoatPosition = _normalRedBoat.GetComponent<Transform>();
		_normalYellowBoatPosition = _normalYellowBoat.GetComponent<Transform>();


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
				_normalBlackBoat.SetActive(true);
				_normalBlackBoatPosition.position = _firstBoatPosition.position;
				break;
			case 1:
				_normalBlueBoat.SetActive(true);
				_normalBlueBoatPosition.position = _firstBoatPosition.position;
				break;
			case 2:
				_normalRedBoat.SetActive(true);
				_normalRedBoatPosition.position = _firstBoatPosition.position;
				break;
			case 3:
				_normalYellowBoat.SetActive(true);
				_normalYellowBoatPosition.position = _firstBoatPosition.position;
				break;
		}

		switch (_freePositions[1])
		{
			case 0:
				_normalBlackBoat.SetActive(true);
				_normalBlackBoatPosition.position = _secondBoatPosition.position;
				break;
			case 1:
				_normalBlueBoat.SetActive(true);
				_normalBlueBoatPosition.position = _secondBoatPosition.position;
				break;
			case 2:
				_normalRedBoat.SetActive(true);
				_normalRedBoatPosition.position = _secondBoatPosition.position;
				break;
			case 3:
				_normalYellowBoat.SetActive(true);
				_normalYellowBoatPosition.position = _secondBoatPosition.position;
				break;
		}

		switch (_freePositions[2])
		{
			case 0:
				_normalBlackBoat.SetActive(true);
				_normalBlackBoatPosition.position = _thirdBoatPosition.position;
				break;
			case 1:
				_normalBlueBoat.SetActive(true);
				_normalBlueBoatPosition.position = _thirdBoatPosition.position;
				break;
			case 2:
				_normalRedBoat.SetActive(true);
				_normalRedBoatPosition.position = _thirdBoatPosition.position;
				break;
			case 3:
				_normalYellowBoat.SetActive(true);
				_normalYellowBoatPosition.position = _thirdBoatPosition.position;
				break;
		}

		switch (_freePositions[3])
		{
			case 0:
				_normalBlackBoat.SetActive(true);
				_normalBlackBoatPosition.position = _fourthBoatPosition.position;
				break;
			case 1:
				_normalBlueBoat.SetActive(true);
				_normalBlueBoatPosition.position = _fourthBoatPosition.position;
				break;
			case 2:
				_normalRedBoat.SetActive(true);
				_normalRedBoatPosition.position = _fourthBoatPosition.position;
				break;
			case 3:
				_normalYellowBoat.SetActive(true);
				_normalYellowBoatPosition.position = _fourthBoatPosition.position;
				break;
		}
	}

}

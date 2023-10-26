using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyBoatsPositionsBehaviour : MonoBehaviour
{

	[SerializeField] private GameObject _easyBlackBoat;
	[SerializeField] private GameObject _easyBlueBoat;
	[SerializeField] private GameObject _easyRedBoat;
	[SerializeField] private GameObject _easyYellowBoat;

	[SerializeField] private RectTransform _firstBoatPosition;
	[SerializeField] private RectTransform _secondBoatPosition;
	[SerializeField] private RectTransform _thirdBoatPosition;
	[SerializeField] private RectTransform _fourthBoatPosition;

	private Transform _easyBlackBoatPosition;
	private Transform _easyBlueBoatPosition;
	private Transform _easyRedBoatPosition;
	private Transform _easyYellowBoatPosition;


	private Dictionary<int, int[]> _positionVariations = new Dictionary<int, int[]>();

	// Start is called before the first frame update
	void Start()
	{
		_easyBlackBoatPosition = _easyBlackBoat.GetComponent<Transform>();
		_easyBlueBoatPosition = _easyBlueBoat.GetComponent<Transform>();
		_easyRedBoatPosition = _easyRedBoat.GetComponent<Transform>();
		_easyYellowBoatPosition = _easyYellowBoat.GetComponent<Transform>();


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
				_easyBlackBoat.SetActive(true);
				_easyBlackBoatPosition.position = _firstBoatPosition.position;
				break;
			case 1:
				_easyBlueBoat.SetActive(true);
				_easyBlueBoatPosition.position = _firstBoatPosition.position;
				break;
			case 2:
				_easyRedBoat.SetActive(true);
				_easyRedBoatPosition.position = _firstBoatPosition.position;
				break;
			case 3:
				_easyYellowBoat.SetActive(true);
				_easyYellowBoatPosition.position = _firstBoatPosition.position;
				break;
		}

		switch (_freePositions[1])
		{
			case 0:
				_easyBlackBoat.SetActive(true);
				_easyBlackBoatPosition.position = _secondBoatPosition.position;
				break;
			case 1:
				_easyBlueBoat.SetActive(true);
				_easyBlueBoatPosition.position = _secondBoatPosition.position;
				break;
			case 2:
				_easyRedBoat.SetActive(true);
				_easyRedBoatPosition.position = _secondBoatPosition.position;
				break;
			case 3:
				_easyYellowBoat.SetActive(true);
				_easyYellowBoatPosition.position = _secondBoatPosition.position;
				break;
		}

		switch (_freePositions[2])
		{
			case 0:
				_easyBlackBoat.SetActive(true);
				_easyBlackBoatPosition.position = _thirdBoatPosition.position;
				break;
			case 1:
				_easyBlueBoat.SetActive(true);
				_easyBlueBoatPosition.position = _thirdBoatPosition.position;
				break;
			case 2:
				_easyRedBoat.SetActive(true);
				_easyRedBoatPosition.position = _thirdBoatPosition.position;
				break;
			case 3:
				_easyYellowBoat.SetActive(true);
				_easyYellowBoatPosition.position = _thirdBoatPosition.position;
				break;
		}

		switch (_freePositions[3])
		{
			case 0:
				_easyBlackBoat.SetActive(true);
				_easyBlackBoatPosition.position = _fourthBoatPosition.position;
				break;
			case 1:
				_easyBlueBoat.SetActive(true);
				_easyBlueBoatPosition.position = _fourthBoatPosition.position;
				break;
			case 2:
				_easyRedBoat.SetActive(true);
				_easyRedBoatPosition.position = _fourthBoatPosition.position;
				break;
			case 3:
				_easyYellowBoat.SetActive(true);
				_easyYellowBoatPosition.position = _fourthBoatPosition.position;
				break;
		}
	}

}

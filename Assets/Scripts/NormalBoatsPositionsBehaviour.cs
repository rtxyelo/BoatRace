using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalBoatsPositionsBehaviour : MonoBehaviour
{
	[Header("Enemy Boats")]
	[SerializeField] private GameObject _normalBlackBoat;
	[SerializeField] private GameObject _normalBlueBoat;
	[SerializeField] private GameObject _normalRedBoat;
	[SerializeField] private GameObject _normalYellowBoat;

	[Header("Boats positions")]
	[SerializeField] private RectTransform _firstBoatPosition;
	[SerializeField] private RectTransform _secondBoatPosition;
	[SerializeField] private RectTransform _thirdBoatPosition;
	[SerializeField] private RectTransform _fourthBoatPosition;

	[Header("Player boats")]
	[SerializeField] private GameObject _easyBlackBoatPlayer;
	[SerializeField] private GameObject _easyBlueBoatPlayer;
	[SerializeField] private GameObject _easyRedBoatPlayer;
	[SerializeField] private GameObject _easyYellowBoatPlayer;

	[SerializeField] private GameObject _normalBlackBoatPlayer;
	[SerializeField] private GameObject _normalBlueBoatPlayer;
	[SerializeField] private GameObject _normalRedBoatPlayer;
	[SerializeField] private GameObject _normalYellowBoatPlayer;

	[SerializeField] private GameObject _mediumBlackBoatPlayer;
	[SerializeField] private GameObject _mediumBlueBoatPlayer;
	[SerializeField] private GameObject _mediumRedBoatPlayer;
	[SerializeField] private GameObject _mediumYellowBoatPlayer;

	[SerializeField] private GameObject _hardBlackBoatPlayer;
	[SerializeField] private GameObject _hardBlueBoatPlayer;
	[SerializeField] private GameObject _hardRedBoatPlayer;
	[SerializeField] private GameObject _hardYellowBoatPlayer;

	// Enemy
	private Transform _normalBlackBoatPosition;
	private Transform _normalBlueBoatPosition;
	private Transform _normalRedBoatPosition;
	private Transform _normalYellowBoatPosition;

	// Player
	private Transform _easyBlackBoatPositionPlayer;
	private Transform _easyBlueBoatPositionPlayer;
	private Transform _easyRedBoatPositionPlayer;
	private Transform _easyYellowBoatPositionPlayer;

	private Transform _normalBlackBoatPositionPlayer;
	private Transform _normalBlueBoatPositionPlayer;
	private Transform _normalRedBoatPositionPlayer;
	private Transform _normalYellowBoatPositionPlayer;

	private Transform _mediumBlackBoatPositionPlayer;
	private Transform _mediumBlueBoatPositionPlayer;
	private Transform _mediumRedBoatPositionPlayer;
	private Transform _mediumYellowBoatPositionPlayer;

	private Transform _hardBlackBoatPositionPlayer;
	private Transform _hardBlueBoatPositionPlayer;
	private Transform _hardRedBoatPositionPlayer;
	private Transform _hardYellowBoatPositionPlayer;

	private string _currentBoatKey = "CurrentBoat";
	private string _currentLevelKey = "CurrentLevel";
	private string _currentBoatColorKey = "_currentBoatColorKey";
	private int _boatType;
	private Dictionary<int, int[]> _positionVariations = new Dictionary<int, int[]>();

	// Start is called before the first frame update
	void Start()
	{
		if (!PlayerPrefs.HasKey(_currentBoatKey))
		{
			PlayerPrefs.SetInt(_currentBoatKey, 0);
		}
		if (!PlayerPrefs.HasKey(_currentBoatColorKey))
		{
			PlayerPrefs.SetInt(_currentBoatColorKey, 0);
		}
		if (!PlayerPrefs.HasKey(_currentLevelKey))
		{
			PlayerPrefs.SetInt(_currentLevelKey, 0);
		}

		PlayerPrefs.SetInt(_currentLevelKey, 1);
		_boatType = PlayerPrefs.GetInt(_currentBoatKey, 0);

		// Enemy
		_normalBlackBoatPosition = _normalBlackBoat.GetComponent<Transform>();
		_normalBlueBoatPosition = _normalBlueBoat.GetComponent<Transform>();
		_normalRedBoatPosition = _normalRedBoat.GetComponent<Transform>();
		_normalYellowBoatPosition = _normalYellowBoat.GetComponent<Transform>();

		// Player
		_easyBlackBoatPositionPlayer = _easyBlackBoatPlayer.GetComponent<Transform>();
		_easyBlueBoatPositionPlayer = _easyBlueBoatPlayer.GetComponent<Transform>();
		_easyRedBoatPositionPlayer = _easyRedBoatPlayer.GetComponent<Transform>();
		_easyYellowBoatPositionPlayer = _easyYellowBoatPlayer.GetComponent<Transform>();

		_normalBlackBoatPositionPlayer = _normalBlackBoatPlayer.GetComponent<Transform>();
		_normalBlueBoatPositionPlayer = _normalBlueBoatPlayer.GetComponent<Transform>();
		_normalRedBoatPositionPlayer = _normalRedBoatPlayer.GetComponent<Transform>();
		_normalYellowBoatPositionPlayer = _normalYellowBoatPlayer.GetComponent<Transform>();

		_mediumBlackBoatPositionPlayer = _mediumBlackBoatPlayer.GetComponent<Transform>();
		_mediumBlueBoatPositionPlayer = _mediumBlueBoatPlayer.GetComponent<Transform>();
		_mediumRedBoatPositionPlayer = _mediumRedBoatPlayer.GetComponent<Transform>();
		_mediumYellowBoatPositionPlayer = _mediumYellowBoatPlayer.GetComponent<Transform>();

		_hardBlackBoatPositionPlayer = _hardBlackBoatPlayer.GetComponent<Transform>();
		_hardBlueBoatPositionPlayer = _hardBlueBoatPlayer.GetComponent<Transform>();
		_hardRedBoatPositionPlayer = _hardRedBoatPlayer.GetComponent<Transform>();
		_hardYellowBoatPositionPlayer = _hardYellowBoatPlayer.GetComponent<Transform>();

		for (int i = 0; i < 24; i++)
		{
			int[] variation = new int[] { i % 4, (i + 1) % 4, (i + 2) % 4, (i + 3) % 4 };
			_positionVariations[i] = variation;
		}
		SetBoatPositionsByColor();
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


		// Easy boat type
		if (_boatType == 0)
		{
			switch (_freePositions[1])
			{
				case 0:
					_easyBlackBoatPlayer.SetActive(true);
					_easyBlackBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
				case 1:
					_easyBlueBoatPlayer.SetActive(true);
					_easyBlueBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
				case 2:
					_easyRedBoatPlayer.SetActive(true);
					_easyRedBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
				case 3:
					_easyYellowBoatPlayer.SetActive(true);
					_easyYellowBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
			}
		}
		// Normal boat type
		else if (_boatType == 1)
		{
			switch (_freePositions[1])
			{
				case 0:
					_normalBlackBoatPlayer.SetActive(true);
					_normalBlackBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
				case 1:
					_normalBlueBoatPlayer.SetActive(true);
					_normalBlueBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
				case 2:
					_normalRedBoatPlayer.SetActive(true);
					_normalRedBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
				case 3:
					_normalYellowBoatPlayer.SetActive(true);
					_normalYellowBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
			}
		}
		// Medium boat type
		else if (_boatType == 2)
		{
			switch (_freePositions[1])
			{
				case 0:
					_mediumBlackBoatPlayer.SetActive(true);
					_mediumBlackBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
				case 1:
					_mediumBlueBoatPlayer.SetActive(true);
					_mediumBlueBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
				case 2:
					_mediumRedBoatPlayer.SetActive(true);
					_mediumRedBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
				case 3:
					_mediumYellowBoatPlayer.SetActive(true);
					_mediumYellowBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
			}
		}
		// Hard boat type
		else if (_boatType == 3)
		{
			switch (_freePositions[1])
			{
				case 0:
					_hardBlackBoatPlayer.SetActive(true);
					_hardBlackBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
				case 1:
					_hardBlueBoatPlayer.SetActive(true);
					_hardBlueBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
				case 2:
					_hardRedBoatPlayer.SetActive(true);
					_hardRedBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
				case 3:
					_hardYellowBoatPlayer.SetActive(true);
					_hardYellowBoatPositionPlayer.position = _secondBoatPosition.position;
					break;
			}
		}

		PlayerPrefs.SetInt(_currentBoatColorKey, _freePositions[1]);
	}

}

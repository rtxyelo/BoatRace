using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardBoatsPositionsBehaviour : MonoBehaviour
{
	[Header("Enemy Boats")]
	[SerializeField] private GameObject _hardBlackBoat;
	[SerializeField] private GameObject _hardBlueBoat;
	[SerializeField] private GameObject _hardRedBoat;
	[SerializeField] private GameObject _hardYellowBoat;
	
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
	private Transform _hardBlackBoatPosition;
	private Transform _hardBlueBoatPosition;
	private Transform _hardRedBoatPosition;
	private Transform _hardYellowBoatPosition;

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

		PlayerPrefs.SetInt(_currentLevelKey, 3);
		_boatType = PlayerPrefs.GetInt(_currentBoatKey, 0);

		// Enemy
		_hardBlackBoatPosition = _hardBlackBoat.GetComponent<Transform>();
		_hardBlueBoatPosition = _hardBlueBoat.GetComponent<Transform>();
		_hardRedBoatPosition = _hardRedBoat.GetComponent<Transform>();
		_hardYellowBoatPosition = _hardYellowBoat.GetComponent<Transform>();

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

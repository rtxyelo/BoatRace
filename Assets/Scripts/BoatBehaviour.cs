using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoatBehaviour : MonoBehaviour
{
	private bool _keyWasPressed = false;
	[SerializeField] private bool _playerBoat;

	private string _currentBoatKey = "CurrentBoat";
	private string _currentLevelKey = "CurrentLevel";
	private string _moneyCountKey = "MoneyCount";
	private string _whoFinishedFirstKey = "WhoFinishedFirst";

	private int _currentLevel;
	private int _boatType;

	[SerializeField] private GameObject _winTable;
	[SerializeField] private TMP_Text _winText;
	[SerializeField] private GameObject _loseTable;
	[SerializeField] private GameObject _darkFilter;
	[SerializeField] private GameObject _backBtn;

	private float time = 0f;
	private bool _continueBtn;
	private GameObject boat;
	private GameObject finishLine;
	private Animator anim;
	private Rigidbody2D rb;
	private Vector3 startPos;

	GameObject[] _easyTagDeactivate;
	GameObject[] _normalTagDeactivate;
	GameObject[] _mediumTagDeactivate;
	GameObject[] _hardTagDeactivate;
	// Start is called before the first frame update
	void Start()
	{
		if (!PlayerPrefs.HasKey(_currentBoatKey))
		{
			PlayerPrefs.SetInt(_currentBoatKey, 0);
		}
		if (!PlayerPrefs.HasKey(_currentLevelKey))
		{
			PlayerPrefs.SetInt(_currentLevelKey, 0);
		}
		if (!PlayerPrefs.HasKey(_whoFinishedFirstKey))
		{
			PlayerPrefs.SetInt(_whoFinishedFirstKey, -1);
		}
		if (!PlayerPrefs.HasKey(_moneyCountKey))
		{
			PlayerPrefs.SetInt(_moneyCountKey, 0);
		}

		_continueBtn = true;

		_currentLevel = PlayerPrefs.GetInt(_currentLevelKey, 0);
		_boatType = PlayerPrefs.GetInt(_currentBoatKey, 0);

		boat = gameObject;
		finishLine = GameObject.Find("FinishLine");
		anim = GetComponent<Animator>();

		startPos = boat.transform.position;

		rb = GetComponent<Rigidbody2D>();
		if (!rb)
		{
			Rigidbody2D _rb = boat.AddComponent<Rigidbody2D>();
			rb = _rb;
		}

		rb.gravityScale = 0;
		rb.angularDrag = 0;

		if (_playerBoat && _boatType == 0)
		{
			rb.drag = 4;
		}
		else if (_playerBoat && _boatType == 1)
		{
			rb.drag = 3;
		}
		else if (_playerBoat && _boatType == 2)
		{
			rb.drag = 2;
		}
		else if (_playerBoat && _boatType == 3)
		{
			rb.drag = 1.5f;
		}
		else if (!_playerBoat && _currentLevel == 0)
		{
			rb.drag = Random.Range(5.5f, 6f);
		}
		else if (!_playerBoat && _currentLevel == 1)
		{
			rb.drag = Random.Range(4.5f, 5f);
		}
		else if (!_playerBoat && _currentLevel == 2)
		{
			rb.drag = Random.Range(3.5f, 4f);
		}
		else if (!_playerBoat && _currentLevel == 3)
		{
			rb.drag = Random.Range(1.5f, 2.5f);
		}
		_easyTagDeactivate = GameObject.FindGameObjectsWithTag("EasyBoat");
		_normalTagDeactivate = GameObject.FindGameObjectsWithTag("NormalBoat");
		_mediumTagDeactivate = GameObject.FindGameObjectsWithTag("MeduimBoat");
		_hardTagDeactivate = GameObject.FindGameObjectsWithTag("HardBoat");
	}

	// Update is called once per frame
	void Update()
	{
		if (!_playerBoat && _continueBtn)
		{
			if (Input.GetKeyDown(KeyCode.Space) && !_keyWasPressed)
			{
				_keyWasPressed = true;
			}

			//Debug.Log("Velocity " + rb.velocity);

			if (_keyWasPressed && rb.velocity.y < 0.3f)
			{
				anim.Play(boat.tag);
				rb.AddForce(new Vector2(0, 20));
			}
			if (boat.transform.position.y > finishLine.transform.position.y)
			{
				PlayerPrefs.SetInt(_whoFinishedFirstKey, 0);
				boat.transform.position = startPos;
				_keyWasPressed = false;
			}
		}
		else if (_continueBtn)
		{
			//Debug.Log("Player velocity " + rb.velocity);

			_backBtn.SetActive(false);

			if (Input.GetKeyDown(KeyCode.Space))
			{
				anim.Play(boat.tag);
				rb.AddForce(new Vector2(0, 20));
			}
			if (boat.transform.position.y > finishLine.transform.position.y)
			{
				PlayerPrefs.SetInt(_whoFinishedFirstKey, 1);
				boat.transform.position = startPos;

				// todo 
				// open finish window
				// add or not add money
				// write time at playerprefs
				// 
			}
		}
		// If win
		if (PlayerPrefs.GetInt(_whoFinishedFirstKey, -1) == 1)
		{
			if (_easyTagDeactivate.Length > 0)
			{
				foreach (GameObject obj in _easyTagDeactivate)
				{
					obj.SetActive(false);
				}
			}
			if (_normalTagDeactivate.Length > 0)
			{
				foreach (GameObject obj in _normalTagDeactivate)
				{
					obj.SetActive(false);
				}
			}
			if (_mediumTagDeactivate.Length > 0)
			{
				foreach (GameObject obj in _mediumTagDeactivate)
				{
					obj.SetActive(false);
				}
			}
			if (_hardTagDeactivate.Length > 0)
			{
				foreach (GameObject obj in _hardTagDeactivate)
				{
					obj.SetActive(false);
				}
			}
			_continueBtn = false;
			_darkFilter.SetActive(true);
			_winTable.SetActive(true);
			_winText.text = "time " + ((uint)time).ToString() + "s";
			PlayerPrefs.SetInt(_moneyCountKey, PlayerPrefs.GetInt(_moneyCountKey, 0) + 200);
		}
		// If lose
		else if (PlayerPrefs.GetInt(_whoFinishedFirstKey, -1) == 0)
		{
			if (_easyTagDeactivate.Length > 0)
			{
				foreach (GameObject obj in _easyTagDeactivate)
				{
					obj.SetActive(false);
				}
			}
			if (_normalTagDeactivate.Length > 0)
			{
				foreach (GameObject obj in _normalTagDeactivate)
				{
					obj.SetActive(false);
				}
			}
			if (_mediumTagDeactivate.Length > 0)
			{
				foreach (GameObject obj in _mediumTagDeactivate)
				{
					obj.SetActive(false);
				}
			}
			if (_hardTagDeactivate.Length > 0)
			{
				foreach (GameObject obj in _hardTagDeactivate)
				{
					obj.SetActive(false);
				}
			}
			_continueBtn = false;
			_darkFilter.SetActive(true);
			_loseTable.SetActive(true);
		}
		PlayerPrefs.SetInt(_whoFinishedFirstKey, -1);
	}
}
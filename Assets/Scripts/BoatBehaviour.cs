using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatBehaviour : MonoBehaviour
{
	private bool _keyWasPressed = false;
	[SerializeField] private bool _playerBoat;
	private string _currentBoatKey = "CurrentBoat";
	private string _currentLevelKey = "CurrentLevel";
	private string _whoFinishedFirstKey = "WhoFinishedFirst";
	private int _currentLevel;
	private int _boatType;
	private GameObject boat;
	private GameObject finishLine;
	private Animator anim;
	private Rigidbody2D rb;
	private Vector3 startPos;

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

	}

	// Update is called once per frame
	void Update()
	{
		if (!_playerBoat)
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
				boat.transform.position = startPos;
				_keyWasPressed = false;
			}
		}
		else
		{
			//Debug.Log("Player velocity " + rb.velocity);

			if (Input.GetKeyDown(KeyCode.Space))
			{
				anim.Play(boat.tag);
				rb.AddForce(new Vector2(0, 20));
			}
			if (boat.transform.position.y > finishLine.transform.position.y)
			{

				boat.transform.position = startPos;

				// todo 
				// open finish window
				// add or not add money
				// write time at playerprefs
				// 
			}
		}
	}
}
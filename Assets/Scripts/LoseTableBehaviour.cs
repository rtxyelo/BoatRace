using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTableBehaviour : MonoBehaviour
{
	public GameObject[] boats = new GameObject[16];

	private string _currentBoatKey = "CurrentBoat";
	private string _currentBoatColorKey = "_currentBoatColorKey";

	private int _currentBoat;
	private int _currentBoatColor;
	// Start is called before the first frame update
	void Start()
    {
		_currentBoat = PlayerPrefs.GetInt(_currentBoatKey, 0);
		_currentBoatColor = PlayerPrefs.GetInt(_currentBoatColorKey, 0);
		GameObject boat = Instantiate(boats[_currentBoat * 4 + _currentBoatColor], gameObject.transform);
		boat.transform.localScale = new Vector3(90, 90, 1);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}

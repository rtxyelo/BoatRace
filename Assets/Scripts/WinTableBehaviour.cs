using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinTableBehaviour : MonoBehaviour
{
    public GameObject Timer;
	public TMP_Text timerText;

	private float _time = -1;
    private TimerBehaviour _timerBehaviour;

    // Start is called before the first frame update
    void Start()
    {
		_timerBehaviour = Timer.GetComponent<TimerBehaviour>();
		if (!Timer)
		{
			Timer = GameObject.Find("Timer");
		}
	}

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeInHierarchy && _time < 0)
        {
			_time = _timerBehaviour.time;
			timerText.text = "time " + ((int)_time).ToString() + "s";
			Timer.SetActive(false);
		}
    }
}

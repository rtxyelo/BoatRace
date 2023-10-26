using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerBehaviour : MonoBehaviour
{
    public TMP_Text canvasText;

	[HideInInspector]
	public float time = 0f;
    [HideInInspector]
	public bool isStart = false;

	// Start is called before the first frame update
	void Start()
    {
        canvasText.text = "0s";
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart)
        {
            time += Time.deltaTime;
            canvasText.text = ((uint)time).ToString() + "s";
        }
    }
}

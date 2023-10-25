using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerBehaviour : MonoBehaviour
{
    public TMP_Text canvasText;

    private float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        canvasText.text = "0s";
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
		canvasText.text = ((uint)time).ToString() + "s";
    }
}

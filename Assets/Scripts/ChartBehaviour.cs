using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;

public class ChartBehaviour : MonoBehaviour
{
    [Header("Texts")]
    public TMP_Text Name;
    public TMP_Text Date;
    public TMP_Text Time;
    public TMP_Text Place;

	// Start is called before the first frame update
	void Start()
    {

	}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setFields(string name = "Elvir", float time = 20, int place = 1, string date = "19.10.2023")
    {
        Name.text = name;
        Date.text = date;
		Time.text = ((uint)time).ToString() +"s";
		Place.text = place.ToString() + " place";
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopBehaviour : MonoBehaviour
{
	public TMP_Text BoatName;

	private GameObject ShopObj;
	private int curentBoat = 0;
	private int maxBoat = 4;

    IEnumerator MoveForwardCorutine()
    {
        for(int i = 0; i < 20; i++)
        {
			ShopObj.transform.position += new Vector3(-5f, 0, 0) / 20f;
            yield return null; 
		}
    }

	IEnumerator MoveBackwardCorutine()
	{
		for (int i = 0; i < 20; i++)
		{
			ShopObj.transform.position += new Vector3(5f, 0, 0) / 20f;
			yield return null;
		}
	}

	public void MoveForward()
    {
		if (curentBoat < maxBoat-1)
		{
			StartCoroutine(MoveForwardCorutine());
			curentBoat++;
			SetName(curentBoat);
		}
	}
	public void MoveBackward()
	{
		if (curentBoat > 0)
		{
			StartCoroutine(MoveBackwardCorutine());
			curentBoat--;
			SetName(curentBoat);
		}
	}

	private void SetName(int boatNum)
	{
		if(curentBoat == 0)
		{
			BoatName.text = "Easy Boat";
		}
		if (curentBoat == 1)
		{
			BoatName.text = "Normal Boat";
		}
		if (curentBoat == 2)
		{
			BoatName.text = "Medium Boat";
		}
		if (curentBoat == 3)
		{
			BoatName.text = "Heavy Boat";
		}
	}

	// Start is called before the first frame update
	void Start()
    {
        ShopObj = gameObject;
	}

    // Update is called once per frame
    void Update()
    {

	}
}

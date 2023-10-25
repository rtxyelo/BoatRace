using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatBehaviour : MonoBehaviour
{
	private bool _keyWasPressed = false;

	private GameObject boat;
	private GameObject finishLine;
	private Animator anim;
	private Rigidbody2D rb;
	private Vector3 startPos;

	// Start is called before the first frame update
	void Start()
	{
		
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
		//rb.drag = 4;
		rb.drag = Random.Range(3.5f, 4f);

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && !_keyWasPressed)
		{
			_keyWasPressed = true;
		}

		Debug.Log(rb.velocity);

		//if (Input.anyKeyDown)
		if (_keyWasPressed && rb.velocity.y < 0.5f)
		{
			anim.Play(boat.tag);
			rb.AddForce(new Vector2(0, 25));
		}
		if (boat.transform.position.y > finishLine.transform.position.y)
		{
			boat.transform.position = startPos;
		}
		/*
        if(boat.transform.position.y < 0)
        {
            boat.transform.position = new Vector2(0, 0);
            rb.velocity = new Vector2(0, 0);
    }
        if(rb.velocity.y < -5) {
      rb.velocity = new Vector2(0,-5);
    }
        */
	}
}
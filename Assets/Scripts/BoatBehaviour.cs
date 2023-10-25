using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatBehaviour : MonoBehaviour
{
    public GameObject boat;
    public GameObject finishLine;
    
    private Animator anim;
    private Rigidbody2D rb;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        finishLine = GameObject.Find("FinishLine");
		anim = GetComponent<Animator>();
		boat = gameObject;

		startPos = boat.transform.position;

		rb = GetComponent<Rigidbody2D>();
        if (!rb)
        {
            Rigidbody2D _rb = boat.AddComponent<Rigidbody2D>();
            rb = _rb;
        }
        rb.gravityScale = 0;
        rb.angularDrag = 0;
        rb.drag = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            anim.Play("EasyBoat");
			rb.AddForce(new Vector2(0, 40));
        }
        if(boat.transform.position.y > finishLine.transform.position.y)
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

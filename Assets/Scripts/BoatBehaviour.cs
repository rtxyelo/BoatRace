using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatBehaviour : MonoBehaviour
{
    public GameObject boat;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            rb.AddForce(new Vector2(0, 40));
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

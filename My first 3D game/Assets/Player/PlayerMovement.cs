using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour {
    

public Rigidbody rb;

    public float Forward = 20f;
    public float Back = -20f;
    public float Right = 20f;
    public float Left = -20f;

    void Start ()
    {  
        
	}
	void FixedUpdate ()
    {
        // rb.AddForce(0, 0, Forward);
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, Forward*Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, Back * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(Right * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(Left * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //if (Input.GetKey("space"))
        //{rb.AddForce(0, 50, 0);}
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * 10;
        }
        if (rb.position.y < -4)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}

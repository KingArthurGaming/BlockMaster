using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerMovementSkript : MonoBehaviour
{


    public Rigidbody rb;
    public float JoyZ = 20f;
    public float JoyX = 20f;
    public float Forward = 20f;
    public float Back = -20f;
    public float Right = 20f;
    public float Left = -20f;
    public void FixedUpdate()
    {
        rb.AddForce(0, 0, Forward * Time.deltaTime, ForceMode.VelocityChange);
        float INPUTH = CrossPlatformInputManager.GetAxis("Horizontal");
        //float INPUTV = CrossPlatformInputManager.GetAxis("Vertical");
        Vector3 virtoal = new Vector3(INPUTH * JoyZ, 0,0);// INPUTV * JoyX
        rb.AddForce(virtoal);
        // rb.AddForce(0, 0, Forward);
        //if (Input.GetKey("w"))
        //{
        //    rb.AddForce(0, 0, Forward * Time.deltaTime, ForceMode.VelocityChange);
        //}
        //if (Input.GetKey("s"))
        //{
        //    rb.AddForce(0, 0, Back * Time.deltaTime, ForceMode.VelocityChange);
        //}
        if (Input.GetKey("d"))
        {
            rb.AddForce(Right * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(Left * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //if (Input.GetKey("space"))
        //{rb.AddForce(0, 50, 0);}
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    GetComponent<Rigidbody>().velocity = Vector3.up * 10;
        //}

        if (rb.position.y < -2)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}

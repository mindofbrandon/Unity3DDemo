// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; // create object to be manipulated in Unity

    public float forwardVelocity = 2000f;
    public float sidewaysVelocity = 500f;
    public float upwardsVelocity = 500f;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Hello, world!");
        // rb.useGravity = false; turns off gravity
        // rb.AddForce(0,200,500); // adds force on object at x,y,z
    }

    // Update is called once per frame
    void FixedUpdate() // must use FixedUpdate instead of Update if coding physics objects
    {
        // deltaTime is used to compensate for slower computers
        rb.AddForce(0, 0, forwardVelocity * Time.deltaTime); // continually adds a force on object

        // get left and right movement on object

        // if a is pressed on keyboard, move left
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysVelocity * Time.deltaTime, 0, 0);
        }

        // if d is pressed on keyboard, move right
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysVelocity * Time.deltaTime, 0, 0);
        }

        // if space is pressed on keyboard, jump
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, upwardsVelocity * Time.deltaTime, 0);
        }

    }
}

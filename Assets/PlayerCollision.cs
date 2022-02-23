// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;


    // if player collides, this function runs
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit the obstacle!"); // print the object with which the player collided with
            movement.enabled = false;
        }
        
    }
}

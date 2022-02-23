// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset; // data type that stores 3 floats

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = player.position; camera postion = players position (in first person)
        transform.position = player.position + offset; // take position of player and add with position of camera
        // Debug.Log(player.position); displays player position to console
    }
}

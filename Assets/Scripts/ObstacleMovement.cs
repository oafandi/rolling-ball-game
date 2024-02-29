using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 0, 400);
    
    // Update is called once per frame
    void Update()
    {
        Console.Write(player.position.z);
        Debug.Log("update");
        if (player.position.z > transform.position.z + 2 * transform.localScale.z) // make better condition for the replacement of obstacles
        {
            transform.position += offset;
            Console.Write("obstacle position is ");
            //Console.(transform.position.z);
        }
    }
}

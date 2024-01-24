using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Player hit an obstacle!\n");
            movement.forwardForce = 0f;
            //movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

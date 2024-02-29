using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private Renderer playerRenderer;
    private WaitForSeconds glitchDuration = new WaitForSeconds(.1f);

    private void Awake()
    {
        playerRenderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Player hit an obstacle!\n");
            movement.forwardForce = 0f;
            movement.rigidbody.velocity = new Vector3(0f, 0f, 0f);
            //movement.enabled = false;
            StartCoroutine(Glitch());
            Destroy(gameObject, 2f);
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private IEnumerator Glitch()
    {
        glitchDuration = new WaitForSeconds(0.1f);
        for (int i = 0; i < 10; i ++)
        {
            playerRenderer.material.SetFloat("_Distance", Random.Range(1f, 3f));
            playerRenderer.material.SetFloat("_Amplitude", Random.Range(7, 13));
            playerRenderer.material.SetFloat("_Speed", Random.Range(20, 30));
            playerRenderer.material.SetFloat("_Amount", Random.Range(0.1f, 0.4f));
            yield return glitchDuration;
        }
        playerRenderer.material.SetFloat("_Amount", 0f);
    }
}

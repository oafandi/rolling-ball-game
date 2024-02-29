using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
	public Transform player;
	public Transform firstGround;
    public Transform secondGround;

    // Update is called once per frame
    void Update()
    {
    	if (player.position.z >= firstGround.position.z + firstGround.localScale.z / 2)
        {
	        Vector3 offset = new Vector3(0, 0, firstGround.localScale.z + secondGround.localScale.z);
	        firstGround.position += offset;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public Transform player;

    public Vector3 offset;
	public Vector3 offsetOnlyZ;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    	offsetOnlyZ = new Vector3(0f, 0f, offset.z);
	}

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.position + offsetOnlyZ;
    }
}

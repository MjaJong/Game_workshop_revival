using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    [Range(1f, 100f)]
    public float movementspeed_Player = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // let player move to some direction
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            Vector3 newPosition = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            transform.Translate(newPosition * movementspeed_Player * Time.deltaTime);

        }

    }
}

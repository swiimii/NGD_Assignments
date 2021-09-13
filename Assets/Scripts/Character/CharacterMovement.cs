using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class CharacterMovement : NetworkBehaviour
{
    // Start is called before the first frame update
    public float movespeed = 5f;
    void Start()
    {
        if (IsLocalPlayer)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.cyan;
            GetComponentInChildren<Camera>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (IsLocalPlayer)
        {
            MovePlayer();
        }
    }

    void MovePlayer()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized * movespeed * Time.deltaTime;
    }
}

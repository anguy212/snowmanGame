﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    float mousePos;
    //private RigidBody2D snowman;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, -4.05f, -0.6572319f);
    }
    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition.x;
        if(mousePos < - 23.4f)
        {
            mousePos = -23.4f;
        }
        else if(mousePos > 23.4f)
        {
            mousePos = 23.4f;
        }
        transform.position = new Vector3(mousePos, -35.25f, -0.6572319f);
    }
}

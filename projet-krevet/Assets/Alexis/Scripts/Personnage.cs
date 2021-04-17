﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personnage : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D rb;
    Vector2 movement;
    public Camera cam;
    


    private void Start()
    {
        
    }


    private void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        transform.LookAt(cam.ScreenToWorldPoint(Input.mousePosition), -Vector3.forward);
        transform.Rotate(new Vector3(90, 0, 0), Space.Self);
    }

    private void FixedUpdate()
    {
        gameObject.transform.position = new Vector2(transform.position.x + (movement.x * Speed), transform.position.y + (movement.y * Speed));

       
    }
}

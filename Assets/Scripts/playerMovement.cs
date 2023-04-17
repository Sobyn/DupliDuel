using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public Rigidbody2D rb;
    Vector2 movement;
    

    void Update()
    {
        //Set X and Y axis
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }    
    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);    }
}

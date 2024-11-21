using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOvement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public FixedJoystick joy;
    
    void FixedUpdate()
    {
        rb.velocity = new Vector3(joy.Horizontal * speed, rb.velocity.y, joy.Vertical * speed);
    }
}


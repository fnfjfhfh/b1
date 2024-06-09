using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{   
    private Rigidbody2D rb;
    void Update()
    {
      rb.velocity = new Vector2(5f,rb.velocity.y);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}

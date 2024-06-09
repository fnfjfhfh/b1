using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrolier : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]private float jumpForce=5f;//private-приватный доступ.
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
       {
        rb.AddForce(new Vector2(0,jumpForce),ForceMode2D.Impulse);
       } 
    }
}

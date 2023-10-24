using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D body; 
    
    // Start is called before the first frame update
    void Awake()
    {
     body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        body.velocity = new Vector2(horizontalInput* speed, verticalInput* speed);
        
        

    }

    private void OnCollisionEnter2D(Collision2D other){
        
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovementBacis : MonoBehaviour
{

    public float speed;

    Rigidbody2D body;
    Transform target;
    Vector2 moveDirection;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (target)
        {
            Vector3 localPosition = (target.position - transform.position).normalized; //Takes the player position from itself
            float angle = Mathf.Atan2(localPosition.y, localPosition.x) * Mathf.Rad2Deg - 90f;
            body.rotation = angle;
            moveDirection = localPosition;
        }
    
    }

    void FixedUpdate()
    {
        if(target)
        {
          
            body.velocity = new Vector2(moveDirection.x , moveDirection.y) * speed;
        }
    }


}

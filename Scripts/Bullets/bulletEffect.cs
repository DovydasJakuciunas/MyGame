using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPhysics : MonoBehaviour
{
    public GameObject hitEffect;
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        //Create the Effect, Quaternion means no rotation
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        
        //Destroys all objects related to the bullet
        Destroy (effect, .2f);
        Destroy (gameObject);
    }

    void Update()
    {
        Destroy(gameObject, 2.5f);
    }
    
}

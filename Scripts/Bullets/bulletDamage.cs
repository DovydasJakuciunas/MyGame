using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDamage : MonoBehaviour
{
    GameObject enemies;
    private void OnTriggerEnter2D(Collider2D col)
    {
    
        if(col.GetComponent<enemyMovementBacis>())
        {
            Destroy(enemies.gameObject);
            Destroy(gameObject);
        }
    }
}

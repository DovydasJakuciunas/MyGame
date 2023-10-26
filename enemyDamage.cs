using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour
{
    [SerializeField]
    private float damageAmount;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<playerMovement>())
        {
            var healthController = collision.gameObject.GetComponent<healthController>();

            healthController.TakeDamage(damageAmount);
        }
    }
}

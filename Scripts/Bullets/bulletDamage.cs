using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDamage : MonoBehaviour
{
    public int Damage;

    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<Health>().Damage(Damage);
        Destroy(gameObject);
    }
}

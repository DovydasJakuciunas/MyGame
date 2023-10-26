using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
   
   public Transform firePoint;
   public GameObject bulletPrefab;

   public float bulletForce = 20f;
  

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.GetComponent<enemySpawner>())
        {
            Destroy(collision.gameObject);
            Destroy(collision);
        }
    }

    void Shoot()
    {
        //Initialises the bullet eg. creates it
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        //Moves the bullet 
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}

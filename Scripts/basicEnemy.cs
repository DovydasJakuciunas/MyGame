using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicEnemy : MonoBehaviour
{

    [SerializeField]
    private int damage = 5;



    [SerializeField]
    private enemyData data;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        SetEnemyValues();
    }


    private void SetEnemyValues()
    {
        damage = data.damage;
    }
 

    public void OnCollisionEnter2D(Collision2D collider)
    {
       
        if(collider.gameObject.tag.Equals("Bullet"))
        {
           
            Destroy(collider.gameObject);
            Destroy(gameObject);
            
        }
    }
}

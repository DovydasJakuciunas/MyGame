using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovementBacis : MonoBehaviour
{

    public int speed;
    public GameObject player;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 localPosition = player.transform.position - transform.position; //Takes the player position from itself
        localPosition = localPosition.normalized;
        transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed,localPosition.z * Time.deltaTime * speed);
    }
}

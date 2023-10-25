using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Enemy",order = 1)]
public class enemyData : ScriptableObject //Allows to customise many of similar objects eg enemys
{
    public int hp;
    public int damage;
    public int speed;

}

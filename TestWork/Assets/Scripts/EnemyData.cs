using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Data",menuName = "ScriptableObjects/Enemy",order = 1)]
public class EnemyData : ScriptableObject
{
    public int hp;
    public int damage;
    public float speed;
    public float attackRate;
    public float rangeOfAttack;
    public float nextAttackTime;
    public float bulletForce;
    public float spawnInterval;
}

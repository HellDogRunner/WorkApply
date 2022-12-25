using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] EnemyData data;
    [SerializeField] private Transform firepoint;
    [SerializeField] private GameObject bulletPrefab;
    
    
    private float _attackRate ;
    private float _nextAttackTime;
    private GameObject _player;
    private GameObject _bullet;
    private void Start()
    {
        _player =GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, _player.transform.position)<data.rangeOfAttack)
        {
            if (Time.time>=_nextAttackTime) 
            {
                Shoot();
                _nextAttackTime = Time.time + 1f / data.attackRate; 
            }
        }

    }

    void Shoot()
    {
        _bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }

}

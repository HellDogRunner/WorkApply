using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Health))]
public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private PlayerData data;
    [SerializeField] private Transform firepoint;
    [SerializeField] private GameObject bulletPrefab;

    private float _nextAttackTime = 0f;
    private GameObject _bullet;
    private void Start()
    {
        GetComponent<Health>().SetHealth(data.hp);
    }

    void Update()
    {
        {
            if (Input.GetMouseButton(0))
            {
                if (Time.time>=_nextAttackTime)
                {
                    Shoot();
                    _nextAttackTime = Time.time + 1f / data.attackRate; 
                }
            }
        }
    }

    void Shoot()
    {
        _bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }

}

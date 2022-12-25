using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyBulletDamage : MonoBehaviour
{
    [SerializeField] private EnemyData data;
    private int _damage;
    private Rigidbody2D _rb;
    private void Start()
    {
        _damage =data.damage;
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(transform.up * data.bulletForce, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Health>()!=null)
        {
            if (col.CompareTag("Player"))
            {
                Health health = col.GetComponent<Health>();
                health.Damage(_damage); 
                Destroy(gameObject);
            }

        }
    }

}

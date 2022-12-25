using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private PlayerData data;
    private Rigidbody2D _rb;
    private void Start()
    {
        Destroy(gameObject,3);
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(transform.up*data.bulletforce,ForceMode2D.Impulse);

    }

    private void OnTriggerEnter2D(Collider2D collision)
   {
       if (collision.GetComponent<Health>()!=null)
       {
           Health health = collision.GetComponent<Health>();
           health.Damage(data.damage);
       }
       if (!collision.CompareTag("Bullet"))
       {
           Destroy(gameObject);
       }
       

   }
    
}

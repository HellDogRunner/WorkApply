using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _health = 100;
    private float _maxhealth=100;
    private KillCounter _killCounter;

    private void Start()
    {
        _killCounter = GameObject.Find("Player").GetComponent<KillCounter>();
    }

    public void SetHealth(int health)
    {
        this._health = health;
        _maxhealth = health;
    }

    public float GetHealth()
    {
        return  this._health;
    }
    public float GetMaxHealth()
    {
        return  this._maxhealth;
    }
    public void Damage(float amount)
    {
        this._health -= amount;
        if (_health<=0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (gameObject.CompareTag("Enemy"))
        {
            _killCounter.AddPoints();
            Destroy(gameObject);
        }
    }
}

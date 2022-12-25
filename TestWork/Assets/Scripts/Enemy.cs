using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Health))]
public class Enemy : MonoBehaviour
{
    [SerializeField]
    EnemyData data;
    
    private int _damage;
    private float _speed;
    private float _attackRate;
    private float _rangeOfAttack;
    private float _nextAttackTime ;
    
    private GameObject _player;
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        SetEnemyValues();
    }

  
    void Update()
    {
        Rotation();
            if (Vector2.Distance(transform.position, _player.transform.position) > _rangeOfAttack)
            {
                Swarm();
            }
    }
    private void SetEnemyValues()
    {
        GetComponent<Health>().SetHealth(data.hp);
        _damage = data.damage;
        _speed = data.speed;
        _attackRate =data.attackRate;
        _rangeOfAttack=data.rangeOfAttack;
        _nextAttackTime=data.nextAttackTime;
        
    }
    private void Rotation()
    {
        transform.up = _player.transform.position - transform.position;
    }
    

    private void Swarm()
    {
        transform.position = Vector2.MoveTowards(transform.position, _player.transform.position, _speed * Time.deltaTime);
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (col.GetComponent<Health>()!=null)
            {
                if (Time.time>=_nextAttackTime)
                {
                    Debug.Log("Attack");
                    col.GetComponent<Health>().Damage(_damage);
                    _nextAttackTime = Time.time + 1f / _attackRate;
                }
            }

            if (this.data.name =="Bomber")  
            {
                this.GetComponent<Health>().Damage(10000);
            }
        }
    }
}

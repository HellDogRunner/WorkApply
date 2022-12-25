using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _healthBarSprite;
    [SerializeField] private Health hp;
    private Vector3 _barOffset= new Vector3(0,-1,0);

    private Camera _cam;

    private void Start()
    {
        _cam = Camera.main;
    }

    public void UpdateHealthBar()
    {
        _healthBarSprite.fillAmount =hp.GetHealth()/hp.GetMaxHealth();
    }

    private void LateUpdate()
    {
        transform.position = _barOffset+transform.parent.position;
        transform.rotation = quaternion.identity;
        UpdateHealthBar();
    }
}

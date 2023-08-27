using System;
using System.Collections;
using System.Collections.Generic;
using Scenes;
using UnityEditorInternal;
using UnityEngine;

public class health : MonoBehaviour, IHealth
{
    public static float maxHealth { get; } = 3;
    public float curHealth { get; set; } = maxHealth;
    
    Collider _Collider;
    

    void Start()
    {
        _Collider = GetComponent<Collider>();
    }
    
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        curHealth -= damage;
        if (curHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}

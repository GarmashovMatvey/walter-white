using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class health : MonoBehaviour
{
    public float hp = 5;
    public Collider _Collider;
    

    void Start()
    {
        _Collider = GetComponent<Collider>();
    }
    
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gumba : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private float speed = 3;
    private Rigidbody _rigidbody;
    private Vector3 _moveDir, targetPos;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = new Vector3(Player.transform.position.x,
                                transform.position.y,
                                Player.transform.position.z);
        transform.LookAt(targetPos);
        _moveDir = _rigidbody.transform.forward * speed + _rigidbody.transform.right + _rigidbody.velocity.y * _rigidbody.transform.up;
        _rigidbody.velocity = _moveDir;
    }
}

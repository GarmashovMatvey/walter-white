using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class TakeItems : MonoBehaviour
{
    private Camera _cam;
    private Vector3 _camDir;
    void Start()
    {
        _cam = GetComponent<Camera>();
    }

    private void Update()
    {
        CheckForColliders();
    }

    void CheckForColliders()
    {
        _camDir = _cam.transform.forward;
        Debug.DrawRay(_cam.transform.position, _camDir*3, Color.cyan, 5);
        if (Input.GetKeyDown(KeyCode.E))
        {
            Physics.Raycast(_cam.transform.position, _camDir, out RaycastHit hit, Mathf.Infinity, 1<<3);
            
            Debug.Log(hit.collider.gameObject.name + "was hit!");
            
        }
    }
}
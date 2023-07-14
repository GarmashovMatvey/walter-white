using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float sensivity = 100f;
    [SerializeField] private Transform playerBody;

    private float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(xRotation, 0f,0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}

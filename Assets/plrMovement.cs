using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public sealed class plrMovement : MonoBehaviour
{
    [Header("Movement settings")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpHeight;
    [SerializeField] private Transform orientation;

    [Header("Ground detection settings")]
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundDistance = 0.2f;
    [SerializeField] private LayerMask groundMask;
    
    private Rigidbody _rb;
    private Vector3 moveDir;
    private bool isGrounded;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        moveDir = orientation.forward * z * moveSpeed + orientation.right * x * moveSpeed + orientation.up * _rb.velocity.y;

        _rb.velocity = moveDir;

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            _rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
    }
}

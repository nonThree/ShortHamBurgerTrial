using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMovement : MonoBehaviour
{
    [Header("Speed Attributes")]
    public int speed;

    [Header("Input Variables")]
    public float moveX;
    public float moveY;

    private Rigidbody rb;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        PlayerInput();
    }

    private void FixedUpdate()
    {
        MoveHand();
    }

    private void PlayerInput()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
    }

    private void MoveHand()
    {
        rb.AddForce(transform.forward * -moveY * speed, ForceMode.Acceleration);
        rb.AddForce(transform.right * -moveX * speed, ForceMode.Acceleration);
    }
}

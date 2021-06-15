using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCar : MonoBehaviour
{
    public Rigidbody rb;
    public Transform targetRight;
    public Transform targetLeft;
    public Transform targetMiddle;

    public float speed = 5f;
    public float horSpeed;
    public float speedTurn;
    public float middle;

    float horizontalInput;

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        //Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove); //+ horizontalMove);
    }

    void Update()
    {
       // horizontalInput = Input.GetAxis("Horizontal");
    }
}

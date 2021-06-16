using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCar : MonoBehaviour
{
    public Rigidbody rb;

    public float speed = 5f;

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

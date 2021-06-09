using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carro : MonoBehaviour
{
    public WheelCollider[] wcs;
    public Transform[] rodas;
    public float ForcaMotor, ForcaVolante, ForcaFreio;
    public Rigidbody rigidCar;

    //private float velMax = 100;

    void Update()
    {
        float t = Input.GetAxis("Vertical") * ForcaMotor;
        float b = (Input.GetKey(KeyCode.Space)) ? ForcaFreio : 0;
        float a = Input.GetAxis("Horizontal");

        wcs[0].motorTorque = t;
        wcs[1].motorTorque = t;
        wcs[2].brakeTorque = b;
        wcs[3].brakeTorque = b;

        float vel = ((rigidCar.velocity.magnitude) / 10.0f) + 0.1f;

        wcs[0].steerAngle = a * ForcaVolante / vel;
        wcs[1].steerAngle = a * ForcaVolante / vel;
    }

    void LateUpdate()
    {
        Vector3 pos;
        Quaternion rot;
        for (int i = 0; i < wcs.Length; i++)
        {
            wcs[i].GetWorldPose(out pos, out rot);
            rodas[i].position = pos;
            rodas[i].rotation = rot;
        }
    }
}

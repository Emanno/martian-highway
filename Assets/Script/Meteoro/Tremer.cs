using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tremer : MonoBehaviour
{
    public static bool treme;
    Vector3 pos;
    [Range(0, 1)]
    public float amplitude;
    float tempo;
    public float maxTime;
    void Start()
    {
        pos = transform.position;
        treme = false;
        tempo = 0;
    }
    void Update()
    {
        if (treme)
        {
            TremeCamera();
            tempo += Time.deltaTime;
            if (tempo > maxTime)
            {
                tempo = 0;
                treme = false;
            }
        }
    }
    void TremeCamera()
    {
        //10 velocidade, 0.5 amplitude
        float t = Mathf.PingPong(Time.time * 10, amplitude);
        transform.position = new Vector3(pos.x, pos.y + t, pos.z);
    }
}
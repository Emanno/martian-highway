using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriarMet : MonoBehaviour
{
    public Rigidbody meteoroPrefab;
    public float Tempo;
    float[] pos = {-1.8f, -0,6f, 0.6f};
    public Transform carro;
    Vector3 offSet;

    private void Start()
    {
        InvokeRepeating("Spawn", 0, Tempo);
        offSet = transform.position - carro.position;
    }

    private void Update()
    {
        transform.position = new Vector3(0, 0, carro.position.z) + offSet;
    }

    void Spawn()
    {
        int r = Random.Range(0, 3);
        Vector3 p = new Vector3(pos[r], 0, 0);
        Instantiate(meteoroPrefab, transform.position + p, transform.rotation);
    }
}

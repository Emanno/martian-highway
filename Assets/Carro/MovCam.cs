using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCam : MonoBehaviour
{
    [SerializeField]
    private Vector3 offset;

    [Range(0, 1)]
    public float suavidade = 0.2f;
    public Transform jogador;

    void Start()
    {

    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, jogador.position + offset, suavidade);
    }
}
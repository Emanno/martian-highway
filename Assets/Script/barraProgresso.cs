using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barraProgresso : MonoBehaviour
{
    public GameObject carro;
    public GameObject final;
    public Slider progresso;
    public float distancia;

    private void Start()
    {
        progresso.minValue = 0;
        progresso.maxValue = 323.3f;
        progresso.value = 0;
    }
    void Update()
    {
        Vector3 dir = final.transform.position - carro.transform.position;

        if (Mathf.Abs(dir.z) < distancia)
        {
            Debug.Log("Final" + dir.z);
            progresso.value = progresso.maxValue - dir.z;
        }
    }
}
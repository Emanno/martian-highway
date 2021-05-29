using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIVIDED : MonoBehaviour
{
    public Transform target;//Esse é o nosso alvo que definimos fora do código
    public Transform carro; //colocamos o carro por fora do codigo
    public float speed = 10.0f; // variavel para ser colocada no calculo do transform.position ao inves de se usar um numero
    public float velProx;
    public float howClose; // variavel para definir quao proximo o carro pode chegar em relação ao alvo!
    private float dist; // variavel para definir a distancia entre o alvo e o carro.
    private float dividir; // variavel para ser utilizada entre a distancia do carro e o alvo (target)
    private float aproximar;// variavel para utilizar como calculo de divisão entre a variavel dividir, alvo(target) e o cometa
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        transform.position = target.position - transform.position - carro.position - target.position ;
        if (dist < howClose)
        {
           
        }





    }
}

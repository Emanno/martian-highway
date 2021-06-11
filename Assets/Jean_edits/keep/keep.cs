using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keep : MonoBehaviour
{
    public Transform target;//Esse é o nosso alvo que definimos fora do código
    public Transform carro; //colocamos o carro por fora do codigo
    public float speed = 10.0f; // variavel para ser colocada no calculo do transform.position ao inves de se usar um numero
    public float velProx;
    public float howClose; // variavel para definir quao proximo o carro pode chegar em relação ao alvo!
    private float dist; // variavel para definir a distancia entre o alvo e o carro.

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(carro.position, transform.position);// calculo para atribuir a distancia de onde o código vai para DIST

        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);//Comando para fazer o que receber o codigo seguir o alvo

        if (dist <= howClose)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, velProx * Time.deltaTime);
        }






    }
}

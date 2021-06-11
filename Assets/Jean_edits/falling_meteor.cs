using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling_meteor : MonoBehaviour
{
    public Transform carro;// entrada da posição do carro
    public Transform target;// entrada do alvo.
    public float speed;// velocidade calculada através da distancia entre o carro e o alvo em tempo real.
    public float speedCarro;
    public float distancia;// distancia entre o carro e o alvo onde o meteoro cai.
    private float dist; // variavel que irá receber o valor por fora da distancia que prédefinirmos para o inicio da queda do meteoro.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // calcular velocidade do carro e colocar sobre a velocidade de "queda" do meteoro.
        // para achar a velocidade eu preciso calcular a distancia percorrida dividida pelo tempo gasto para percorrer a distancia
        Vector3 prevPos = carro.position;
        speed = Mathf.RoundToInt(Vector3.Distance(prevPos, carro.transform.position / Time.frameCount));
        // programar o meteoro para seguir o alvo dentro da condição de proximidade do carro.
        dist = Vector3.Distance(target.position, carro.position);
        if (dist <= distancia)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        // programar o meteoro para se desintegrar ao tocar o chão.
        // programar o sumiço do meteoro depois de 5 segundos.
    }
}

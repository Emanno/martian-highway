using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SistemaDeVida : MonoBehaviour
{
    public Slider barraDeVida;

    public float vidaMaxima = 100.0f;

    public string GameOverScene = "gameOver";

    private void Start()
    {
        barraDeVida.minValue = 0;
        barraDeVida.maxValue = vidaMaxima;
        barraDeVida.value = vidaMaxima;
    }

    private void Update()
    {
        ControleDeVida();
    }

    private void ControleDeVida()
    {
        if (barraDeVida.value >= vidaMaxima)
        {
            barraDeVida.value = vidaMaxima;
        }

        if (barraDeVida.value <= barraDeVida.minValue)
        {
            barraDeVida.value = barraDeVida.minValue;
        }
    }

    public void Dano(float dano)
    {
        barraDeVida.value -= dano;

        if(barraDeVida.value <= barraDeVida.minValue)
        {
            SceneManager.LoadScene(GameOverScene);
        }
    }

    public void Recuperar(float extra)
    {
        barraDeVida.value += extra;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    public string Cena1, Cena2;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            //col.gameObject.GetComponent<Pontuacao>();
            if (Pontuacao.score >= 8)
            {
                SceneManager.LoadScene(Cena1);
            }
            else
            {
                SceneManager.LoadScene(Cena2);
            }
            
        }
    }
}

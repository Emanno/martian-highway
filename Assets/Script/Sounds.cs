using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public static Sounds Instance;

    public AudioClip Ferrugem;
    public AudioClip Pontuacao;
    public AudioClip Escudo;
    public AudioClip Meteoro;

void Awake()
    {
        if(Instance != null)
        {
            //.LogError("Múltiplas Instâncias");
        }

        Instance = this;
    }

    public void SomFerrugem()
    {
        MakeSound (Ferrugem);
    }
    public void SomPontuacao()
    {
        MakeSound (Pontuacao);
    }
    public void SomEscudo()
    {
        MakeSound (Escudo);
    }
    public void SomMeteoro()
    {
        MakeSound (Meteoro);
    }

    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }

}

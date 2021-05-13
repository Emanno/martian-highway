using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RochaDano : MonoBehaviour
{
    public float dano = 25.0f;

    private void OnCollisionEnter(Collision col)
    {
        SistemaDeVida player = col.gameObject.GetComponent<SistemaDeVida>();
        if (player != null)
        {
            player.Dano(dano);
        }
    }
}

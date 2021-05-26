using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ferrugem : MonoBehaviour
{
    public float dano = 25.0f;

    private void OnTriggerEnter(Collider other)
    {
        SistemaDeVida player = other.GetComponent<SistemaDeVida>();
        if(player != null)
        {
            player.Dano(dano);
        }

        if (other.CompareTag("Player") == true)
        {
            GetComponent<AudioSource>().Play();
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<MeshCollider>().enabled = false;
            Destroy(this.gameObject, 1.0f);
        }


    }
}

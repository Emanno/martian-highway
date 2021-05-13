using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Escudo : MonoBehaviour
{
    public float Recuperar = 25.0f;

    private void OnCollisionEnter(Collision col)
    {
        SistemaDeVida player = col.gameObject.GetComponent<SistemaDeVida>();
        if (player != null)
        {
            player.Recuperar(recup);
        }
    }
}*/

public class Escudo : MonoBehaviour
{
    public float extra = 25.0f;

    private void OnTriggerEnter(Collider other)
    {
        SistemaDeVida player = other.GetComponent<SistemaDeVida>();
        if (player != null)
        {
            player.Recuperar(extra);
        }

        if (other.CompareTag("Player") == true)
        {
            GetComponent<AudioSource>().Play();
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<CapsuleCollider>().enabled = false;
            Destroy(this.gameObject, 2.0f);
        }


    }
}

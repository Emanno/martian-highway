using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public ParticleSystem deathParticles;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject)
        {
            Destroy();
        }
    }

    public void Destroy()
    {
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

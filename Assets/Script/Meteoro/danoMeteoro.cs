using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danoMeteoro : MonoBehaviour
{
    public static danoMeteoro Instance;

    public float dano = 25.0f;
    public float disMin = 5;
    public Rigidbody rb;
    public Vector3 vel;
    public Vector3 velQueda = new Vector3(0, -20, -2);
    public GameObject carro;

    void Start()
    {
        rb.velocity = vel;
    }

    void Update()
    {
        Vector3 dir = carro.transform.position - transform.position;

        if (Mathf.Abs(dir.z) < disMin)
        {
            //rb.useGravity = true;
            //rb.AddForce(velQueda);
            rb.velocity = velQueda;
            Debug.Log("Perto" + dir.z);
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        SistemaDeVida player = col.gameObject.GetComponent<SistemaDeVida>();
        if (player != null)
        {
            player.Dano(dano);
        }
        GetComponent<AudioSource>().Play();
        //GetComponent<MeshRenderer>().enabled = false;
        //GetComponent<SphereCollider>().enabled = false;
        Destroy(this.gameObject, 6.0f);
    }
}

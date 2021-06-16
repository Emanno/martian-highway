using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public Text scoreTxt;
    public static int score;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        scoreTxt.text = (score + "/8 cristais").ToString();
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            score++;
            GetComponent<AudioSource>().Play();
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<MeshCollider>().enabled = false;
            Destroy(this.gameObject, 2.0f);
        }
    }
}

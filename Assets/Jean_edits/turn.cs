using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{
    public CharacterController controller;

    public float horSpeed;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 0.5f)
        {
            StartCoroutine(RightMove());
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -0.8f)
        {
            StartCoroutine(LeftMove());
        }
    }
    IEnumerator RightMove()
    {
        for (float i = 0; i < 0.19999999999999999999999f; i += 0.02f)
        {
            controller.Move(Vector3.right * Time.fixedDeltaTime * horSpeed);
            yield return null;

        }
    }

    IEnumerator LeftMove()
    {
        for (float i = 0; i < 0.19999999999999999999999f; i += 0.02f)
        {
            controller.Move(Vector3.left * Time.fixedDeltaTime * horSpeed);
              yield return null;

        }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UItext : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreTxt;
    [SerializeField] GameObject Final;

        private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private static UItext instance;

    public static UItext MyInstance
    {
        get
        {
            if(instance == null)
            {
                instance = new UItext();
            }
            return instance;
        }
    }
}

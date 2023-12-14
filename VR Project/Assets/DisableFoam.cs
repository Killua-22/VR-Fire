using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableFoam : MonoBehaviour
{
    public GameObject Foam;
    void Start()
    {
        
    }

    public void OnSelect()
    {
        Foam.SetActive(true);
    }
    void Update()
    {
        
    }
}

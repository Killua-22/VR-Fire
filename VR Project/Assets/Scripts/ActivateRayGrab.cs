using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateRayGrab : MonoBehaviour
{
    public GameObject LeftRayGrab;
    public GameObject RightRayGrab;

    public XRDirectInteractor LeftDirectGrab;
    public XRDirectInteractor RightDirectGrab;


    void Start()
    {
        
    }

    
    void Update()
    {
        LeftRayGrab.SetActive(LeftDirectGrab.interactablesSelected.Count == 0);
        RightRayGrab.SetActive(RightDirectGrab.interactablesSelected.Count == 0);
    }
}

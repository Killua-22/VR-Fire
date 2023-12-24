using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class DisableFoam : MonoBehaviour
{
    public GameObject Foam;
    XRBaseInteractable interactable;
    
    XRGrabInteractable grabbable;
    //public XRGrabInteractable HoseGrabbable;
    public InputActionProperty LeftGrab;
    public InputActionProperty RightGrab;
    LayerMask left, right;
    public bool LeftSpray, RightSpray;
 
    void Start()
    {
        interactable = GetComponent<XRBaseInteractable>();
        grabbable = GetComponent<XRGrabInteractable>();
       
    }

    public void OnSelect()
    {
       
        Foam.SetActive(true);
        if (RightGrab.action.WasPressedThisFrame())
        {
            Debug.Log("Selected using Right Hand");
            interactable.interactionLayers = InteractionLayerMask.GetMask("Right Controller");
            RightSpray = true;
            LeftSpray = false;

        }

        if (LeftGrab.action.WasPressedThisFrame())
        {
            Debug.Log("Selected using Left Hand");
            interactable.interactionLayers = InteractionLayerMask.GetMask("Left Controller");
            LeftSpray = true;
            RightSpray = false;
        }
       
    }

    public void OnExit()
    {
        Debug.Log("Fire Extinguisher deselected");
        interactable.interactionLayers = InteractionLayerMask.GetMask("Direct Grab");
    }
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class DisableFoam : MonoBehaviour
{
    public GameObject Foam;
    XRGrabInteractable interactable;
    public InputActionProperty LeftGrab;
    public InputActionProperty RightGrab;
 
    void Start()
    {
        interactable = GetComponent<XRGrabInteractable>();
    }

    public void OnSelect()
    {
        Foam.SetActive(true);
        interactable.interactionLayers = LayerMask.GetMask("Right Controller");
       

    }
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class FoamTrigger : MonoBehaviour
{
    public GameObject LeftController;
    public GameObject RightController;
    public ParticleSystem foam;

    public InputActionProperty LeftTrigger;
    public InputActionProperty RightTrigger;
    XRGrabInteractable grabbable;

    void Start()
    {
        grabbable = GetComponent<XRGrabInteractable>();
    }

   

    void Update()
    {
        
        if (RightTrigger.action.ReadValue<float>() > 0.1f)
        {
            foam.Play();
        }

        else
        {
            foam.Stop();
        }
    }
}

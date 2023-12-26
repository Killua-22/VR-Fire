using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class FoamTrigger : MonoBehaviour
{
    //[SerializeField]
    //private float amountExtinguishedperSecond = 0.5f;
    public GameObject LeftController;
    public GameObject RightController;
    public ParticleSystem foam;

    public InputActionProperty LeftTrigger;
    public InputActionProperty RightTrigger;
    XRGrabInteractable grabbable;
    public GameObject endAnchor;
    private bool isFoamPlaying = false;
    DisableFoam df;
    public GameObject pivot;
    Quaternion targetRotation;
    float triggerValue;

    void Start()
    {
        grabbable = GetComponent<XRGrabInteractable>();
        df = GetComponent<DisableFoam>();
    }

    void Update()
    {

        if (df.RightSpray && !(df.LeftSpray) && RightTrigger.action.ReadValue<float>() > 0.1f)
        {
            foam.Play();
            isFoamPlaying = true;
            //triggerValue = RightTrigger.action.ReadValue<float>();
            
            //targetRotation = Quaternion.Euler(pivot.transform.eulerAngles.x, pivot.transform.eulerAngles.y, pivot.transform.eulerAngles.z + 14.5f);
            //pivot.transform.rotation = targetRotation;
        }

        else if (df.LeftSpray && !(df.RightSpray) && LeftTrigger.action.ReadValue<float>() > 0.1f)
        {
            foam.Play();
            isFoamPlaying = true;
        }

        else
        {
            foam.Stop();
            isFoamPlaying = false;
        }
    }

    public bool IsFoamPlaying()
    {
        return isFoamPlaying;
    }


}

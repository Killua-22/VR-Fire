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

    void Start()
    {
        grabbable = GetComponent<XRGrabInteractable>();
        
    }

   

    void Update()
    {
        
        if (RightTrigger.action.ReadValue<float>() > 0.1f)
        {
            foam.Play();
            //if(Physics.Raycast(endAnchor.transform.position, endAnchor.transform.forward, out RaycastHit hit, 100f) && hit.collider.TryGetComponent(out FireScript fire))
            //{
            //    fire.TryExtinguish(amountExtinguishedperSecond * Time.deltaTime);
            //    Debug.Log(hit.collider.name);
            //}
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class EndAnchorScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private float amountExtinguishedperSecond = 0.5f;
    public GameObject extinguisherSmoke;
    public ParticleSystem ex_smoke;
    public GameObject endAnchor;


    public XRController controller;

    void Start()
    {
        ex_smoke = extinguisherSmoke.GetComponentInChildren<ParticleSystem>();
        if(ex_smoke.isPlaying)
        {
            ex_smoke.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool isTriggerPressed = false;
        if (controller.inputDevice.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out isTriggerPressed) && isTriggerPressed)
        {
            
            if (ex_smoke.isPlaying)
            {
                ex_smoke.Stop();
            }
            else
            {
                ex_smoke.Play();
                if (Physics.Raycast(endAnchor.transform.position, endAnchor.transform.forward, out RaycastHit hit, 100f) && hit.collider.TryGetComponent(out FireScript fire))
                {
                    fire.TryExtinguish(amountExtinguishedperSecond * Time.deltaTime);
                    Debug.Log(hit.collider.name);
                }
            }
                
            
        }
        

        
    }
}

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
    //public GameObject extinguisherSmoke;
    //public ParticleSystem ex_smoke;
    public GameObject endAnchor;
    public FoamTrigger foamTrigger;

    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
        if (foamTrigger.IsFoamPlaying())
        {
            int layerMask = LayerMask.GetMask("Fire");
            if (Physics.Raycast(endAnchor.transform.position, endAnchor.transform.forward, out RaycastHit hit, 100f, layerMask))
            {
                Debug.Log(hit.collider.name);
                if(hit.collider.TryGetComponent(out FireScript fire))
                {
                    fire.TryExtinguish(amountExtinguishedperSecond * Time.deltaTime);
                    Debug.Log("Extinguishing");
                }
                
            }
        }


    }
}

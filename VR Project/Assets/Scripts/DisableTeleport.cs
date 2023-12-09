using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DisableTeleport : MonoBehaviour
{

    public GameObject LeftTeleportation;
    public GameObject RightTeleportation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeftTeleportOff()
    {

        LeftTeleportation.GetComponent<XRRayInteractor>().enabled = false;
        //LeftTeleportation.SetActive(false);
        //RightTeleportation.SetActive(false);

    }

    public void LeftTeleportOn()
    {

        //RightTeleportation.GetComponent<XRRayInteractor>().enabled = true;
        LeftTeleportation.GetComponent<XRRayInteractor>().enabled = true;
    }

    public void RightTeleportOff()
    {
        RightTeleportation.GetComponent<XRRayInteractor>().enabled = false;
        //LeftTeleportation.SetActive(false);
        //RightTeleportation.SetActive(false);

    }

    public void RightTeleportOn()
    {

        RightTeleportation.GetComponent<XRRayInteractor>().enabled = true;
        //LeftTeleportation.GetComponent<XRRayInteractor>().enabled = true;
    }
}


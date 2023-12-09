using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject LeftTeleportation;
    public GameObject RightTeleportation;

    public InputActionProperty LeftSelect;
    public InputActionProperty RightSelect;


    void Update()
    {
        LeftTeleportation.SetActive(LeftSelect.action.ReadValue<float>() > 0.1f);
        RightTeleportation.SetActive(RightSelect.action.ReadValue<float>() > 0.1f);
    }
}

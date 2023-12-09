using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class MenuButtonManager : MonoBehaviour
{
    public GameObject Menu;
    public InputActionProperty MenuButton;
    public Transform Head;
    public float spawnDistance = 2;


    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(MenuButton.action.WasPressedThisFrame())
        {
            Menu.SetActive(!Menu.activeSelf);

            Menu.transform.position = Head.position + new Vector3(Head.forward.x, 0, Head.forward.z).normalized * spawnDistance;
        }

        Menu.transform.LookAt(new Vector3(Head.position.x, Menu.transform.position.y, Head.position.z));
        Menu.transform.forward *= -1;
        
        
    }
}

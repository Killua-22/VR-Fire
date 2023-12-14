using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisherScript : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isHeld = false;

    //[SerializeField]
    //private float amountExtinguishedperSecond = 0.5f;

    //public GameObject fireExtinguisher;


    private void Update()
    {
        //if (Physics.Raycast(fireExtinguisher.transform.position, fireExtinguisher.transform.forward, out RaycastHit hit, 100f) && hit.collider.TryGetComponent(out FireScript fire))
        //{
        //    fire.TryExtinguish(amountExtinguishedperSecond * Time.deltaTime);
        //    Debug.Log(hit.collider.name);
        //}
    }

    // Call this function when the fire extinguisher is picked up
    public void Pickup()
    {
        isHeld = true;
    }

    // Call this function when the fire extinguisher is released
    public void Release()
    {
        isHeld = false;
    }
}

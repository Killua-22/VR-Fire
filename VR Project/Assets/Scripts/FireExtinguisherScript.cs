using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisherScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float amountExtinguishedperSecond = 0.5f;

    public GameObject fireExtinguisher;


    private void Update()
    {
        if (Physics.Raycast(fireExtinguisher.transform.position, fireExtinguisher.transform.forward, out RaycastHit hit, 100f) && hit.collider.TryGetComponent(out FireScript fire))
        {
            fire.TryExtinguish(amountExtinguishedperSecond * Time.deltaTime);
            Debug.Log(hit.collider.name);
        }
    }
}

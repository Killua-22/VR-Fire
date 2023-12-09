using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnActivate : MonoBehaviour
{
    public GameObject Bullet;
    public Transform SpawnPoint;
    public float BulletSpeed = 20;
    
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    
    void Update()
    {
        
    }

    void FireBullet(ActivateEventArgs arg)
    {
        GameObject SpawnedBullet = Instantiate(Bullet);
        SpawnedBullet.transform.position = SpawnPoint.transform.position;
        SpawnedBullet.GetComponent<Rigidbody>().velocity = SpawnPoint.forward * BulletSpeed;
        Destroy(SpawnedBullet, 7);
        
       
    }
}

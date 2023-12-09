using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    [SerializeField, Range(0f, 1f)] private float currentIntensity = 1.0f;

    private float[] startInternsities = new float[0];

    float timeLastWatered = 0;
    [SerializeField]
    private float regenDelay = 2.5f;
    [SerializeField]
    private float regenRate = 0.1f;

    [SerializeField] private ParticleSystem[] fireParticleSystems = new ParticleSystem[0];

    private bool isLit = true;
    // Start is called before the first frame update
    void Start()
    {
        startInternsities = new float[fireParticleSystems.Length];

        for (int i = 0; i < fireParticleSystems.Length; i++)
        {
            startInternsities[i] = fireParticleSystems[i].emission.rateOverTime.constant;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isLit && currentIntensity < 1.0f && Time.time - timeLastWatered >= regenDelay)
        {
            currentIntensity += regenRate * Time.deltaTime;
            ChangeIntensity();
        }

    }

    public bool TryExtinguish(float amount)
    {
        currentIntensity -= amount;

        ChangeIntensity();

        if (currentIntensity <= 0)
        {
            isLit = false;
            return true;
        }

        return false;
    }

    private void ChangeIntensity()
    {
        for (int i = 0; i < fireParticleSystems.Length; i++)
        {
            var emission = fireParticleSystems[i].emission;
            emission.rateOverTime = currentIntensity * startInternsities[i];

        }
    }
}

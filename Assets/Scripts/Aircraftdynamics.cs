using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraftdynamics : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField]
    float forceforward=1f;
    [SerializeField] Throttle throttle;
    [SerializeField] GameObject CeneterOfMass;


    // Start is called before the first frame update
    void Start()
    {
        rb.centerOfMass = CeneterOfMass.transform.localPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float percentage = throttle._perposition();

        rb.AddForce(-rb.transform.forward * forceforward * percentage, ForceMode.Acceleration);

    }
}

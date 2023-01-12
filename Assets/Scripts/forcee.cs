using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcee : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    [SerializeField]float a = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rb.AddForce(-Vector3.forward * a, ForceMode.Acceleration);
    }
}


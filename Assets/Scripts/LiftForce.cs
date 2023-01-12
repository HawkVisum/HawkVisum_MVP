using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftForce : MonoBehaviour
{
    [SerializeField] float Area;
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject Aircraft;
    [SerializeField] GameObject gameObject;
    [SerializeField] LiftCalculation liftCalculation;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 VangleAircraft = Aircraft.transform.rotation.eulerAngles;
        float angleAircraft = VangleAircraft.x;
        Vector3 VangleObject = gameObject.transform.localRotation.eulerAngles;
        float angleObject = VangleObject.x;
        if (angleAircraft > 180f)
        {
            angleAircraft -= 360f;
        }
        if (angleObject > 180f)
        {
            angleObject -= 360f;
        }

        float finalAOA = angleObject + angleAircraft;

        Vector3 forceUP= liftCalculation.liftForce(Area, finalAOA);

        rb.AddForceAtPosition(forceUP, gameObject.transform.position);
    }
}

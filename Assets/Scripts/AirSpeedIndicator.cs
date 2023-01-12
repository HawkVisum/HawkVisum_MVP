using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirSpeedIndicator : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    float mpstoKnots = 1.94384f;
    [SerializeField]
    AircraftPhysics aircraftPhysics;
    [SerializeField] float maxRot;
    [SerializeField] GameObject needle;
    [SerializeField] GameObject[] gameObjects;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = rb.velocity.magnitude;
        speed *= mpstoKnots;
        Point(speed);
    }

    private void Point(float speed)
    {
        float needleangle,needlefrac;
        if (speed <= 40)
        {
            needlefrac = Mathf.InverseLerp(0, 40, speed);
            needleangle = Mathf.Lerp(0, gameObjects[0].transform.localRotation.eulerAngles.z, needlefrac);
        }
        else if (speed <= 60)
        {
            needlefrac = Mathf.InverseLerp(40, 60, speed);
            needleangle = Mathf.Lerp(gameObjects[0].transform.localRotation.eulerAngles.z, gameObjects[1].transform.localRotation.eulerAngles.z, needlefrac);
        }
        else if (speed <= 80)
        {
            needlefrac = Mathf.InverseLerp(60, 80, speed);
            needleangle = Mathf.Lerp(gameObjects[1].transform.localRotation.eulerAngles.z, gameObjects[2].transform.localRotation.eulerAngles.z, needlefrac);
        }
        else if (speed <= 100)
        {
            needlefrac = Mathf.InverseLerp(80, 100, speed);
            needleangle = Mathf.Lerp(gameObjects[2].transform.localRotation.eulerAngles.z, gameObjects[3].transform.localRotation.eulerAngles.z, needlefrac);
        }
        else if (speed <= 120)
        {
            needlefrac = Mathf.InverseLerp(100, 120, speed);
            needleangle = Mathf.Lerp(gameObjects[3].transform.localRotation.eulerAngles.z, gameObjects[4].transform.localRotation.eulerAngles.z, needlefrac);
        }
        else if (speed <= 140)
        {
            needlefrac = Mathf.InverseLerp(120, 140, speed);
            needleangle = Mathf.Lerp(gameObjects[4].transform.localRotation.eulerAngles.z, gameObjects[5].transform.localRotation.eulerAngles.z, needlefrac);
        }
        else if (speed <= 160)
        {
            needlefrac = Mathf.InverseLerp(140, 160, speed);
            needleangle = Mathf.Lerp(gameObjects[5].transform.localRotation.eulerAngles.z, gameObjects[6].transform.localRotation.eulerAngles.z, needlefrac);
        }
        else
        {
            needleangle = gameObjects[6].transform.localRotation.eulerAngles.z;
        }
        transform.localRotation = Quaternion.Euler(0, 0, needleangle);
    }

}

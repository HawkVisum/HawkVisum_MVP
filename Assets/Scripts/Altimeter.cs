using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altimeter : MonoBehaviour
{
    [SerializeField]
    GameObject x100;
    [SerializeField]
    GameObject x1000;
    [SerializeField]
    GameObject x10000;
    [SerializeField]
    GameObject Plane;
    [SerializeField]
    GameObject Aircraft;
    public float meterstofeet = 3.2808f;
    float sealevelofplane = 3002f;

    public State state;

    private float MaxHeight = 0f;

    void Update()
    {
        float height = Aircraft.transform.position.y - Plane.transform.position.y;
        float heightinfeets = height * meterstofeet + sealevelofplane;
        handlehands(heightinfeets);

        if (height > MaxHeight)
        {
            MaxHeight = height;
        }

        state.maxHeight = MaxHeight;
    }

    private void handlehands(float height)
    {
        float hx100 = height % 1000;
        float hx1000 = height % 10000;
        float hx10000 = height % 100000;

        hx100 = Mathf.InverseLerp(0, 1000, hx100);
        hx1000 = Mathf.InverseLerp(0, 10000, hx1000);
        hx10000 = Mathf.InverseLerp(0, 100000, hx10000);

        hx100 = Mathf.Lerp(0, 360, hx100);
        hx1000 = Mathf.Lerp(0, 360, hx1000);
        hx10000 = Mathf.Lerp(0, 360, hx10000);

        x100.transform.localRotation = Quaternion.Euler(0, 0, hx100);
        x1000.transform.localRotation = Quaternion.Euler(0, 0, hx1000);
        x10000.transform.localRotation = Quaternion.Euler(0, 0, hx10000);
    }
}

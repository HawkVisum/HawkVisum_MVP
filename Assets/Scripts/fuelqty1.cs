using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class fuelqty1 : MonoBehaviour
{
    [SerializeField] private Transform magswit, magstart, fuelqty, fuelqtydef;
    private Quaternion initialx;
    private Vector3 v;
    void Start()
    {
        initialx = fuelqty.rotation;
        v = fuelqty.position;
    }

    void Update()
    {
        float x = Math.Abs(Quaternion.Angle(magswit.rotation, magstart.rotation));
        bool b = x < 7.8;
        if (b)
        {
            transform.position = fuelqtydef.position;
            transform.rotation = Quaternion.Slerp(fuelqty.rotation, fuelqtydef.rotation, Time.deltaTime * 2);
        }
        else
        {
            transform.position = v;
            transform.rotation = Quaternion.Slerp(fuelqty.rotation, initialx, Time.deltaTime * 2);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class engineoil_pres : MonoBehaviour
{
    [SerializeField] private Transform magswit, magstart, pressure, pres_def;
    private Quaternion initialx;
    private Vector3 v;
    void Start()
    {
        initialx = pressure.rotation;
        v = pressure.position;
    }

    void Update()
    {
        float x = Math.Abs(Quaternion.Angle(magswit.rotation, magstart.rotation));
        bool b = x < 7.8;
        if (b)
        {
            transform.position = pres_def.position;
            transform.rotation = Quaternion.Slerp(pressure.rotation, pres_def.rotation, Time.deltaTime * 2);
        }
        else
        {
            transform.position = v;
            transform.rotation = Quaternion.Slerp(pressure.rotation, initialx, Time.deltaTime * 2);
        }
    }
}

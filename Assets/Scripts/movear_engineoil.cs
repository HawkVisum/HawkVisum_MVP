using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class movear_engineoil : MonoBehaviour
{
    [SerializeField] private Transform magswit, magstart, temperature, temp_def;
    private Quaternion initialx;
    private Vector3 v;
    void Start()
    {
        initialx = temperature.rotation;
        v = temperature.position;
    }

    void Update()
    {
        float x = Math.Abs(Quaternion.Angle(magswit.rotation, magstart.rotation));
        bool b = x < 7.8;
        if(b)
        {
            transform.position = temp_def.position;
            transform.rotation = Quaternion.Slerp(temperature.rotation, temp_def.rotation, Time.deltaTime*2);
        }
        else
        {
            transform.position = v;
            transform.rotation = Quaternion.Slerp(temperature.rotation, initialx, Time.deltaTime * 2);
        }
    }
}

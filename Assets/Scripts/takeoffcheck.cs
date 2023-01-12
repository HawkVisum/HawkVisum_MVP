//before takeoff checklist

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class takeoffcheck : MonoBehaviour
{
    // Start is called before the first frame update
    float delay = 2.5f, curtime = 0;
    public Transform parkbrake;
    public GameObject takeofflist;
    Vector3 park;
    public TextMeshProUGUI parkb, fuelq;
    void Start()
    {
        park = parkbrake.position;
        Tools.lockedLayers = 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

        parkb.gameObject.SetActive(false);
        fuelq.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(parkbrake.position != park && parkb.gameObject.activeSelf)
        {
            var p_t = parkb.transform.GetChild(0).gameObject;
            if (p_t.GetComponent<Toggle>().isOn)
            {
                Tools.lockedLayers = 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("parkingBrake") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");
                if (Time.time - curtime > delay)
                {
                    curtime = Time.time;
                    parkb.gameObject.SetActive(false);
                    fuelq.gameObject.SetActive(true);
                }
            }
        }
        //manual checking off 
        if(fuelq.gameObject.activeSelf)
        {

            if (fuelq.transform.GetChild(0).gameObject.GetComponent<Toggle>().isOn)
            {

                var boolean = GameObject.Find("done");
                if (boolean.GetComponent<Toggle>().isOn)
                {


                    Tools.lockedLayers = 0;
                    if (Time.time - curtime > delay)
                    {
                        fuelq.gameObject.SetActive(false);
                        takeofflist.SetActive(false);
                    }
                }
            }
        }
    }
}

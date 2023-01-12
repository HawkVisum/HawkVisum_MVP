using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class list_block : MonoBehaviour
{
    // Start is called before the first frame update
    //
    //public GameObject masteralt, masterbat, avionic1, avionic2, parkingbreak, flapadj, door, fuelsel, fuelshutoff, beacon, throttle, mixture, fuelpump, ignition, preflightcl, enginestart, beforetakeoff;
    void Start()
    {

        Tools.lockedLayers = 1 << LayerMask.NameToLayer("Preflight") | 1 << LayerMask.NameToLayer("EngineStart") | 1 << LayerMask.NameToLayer("BeforeTakeoff") | 1 << LayerMask.NameToLayer("preandstart") | 1 << LayerMask.NameToLayer("preandtake");
        /*masteralt.SetActive(false);
        masterbat.SetActive(false);
        avionic1.SetActive(false);
        avionic2.SetActive(false);
        parkingbreak.SetActive(false);
        flapadj.SetActive(false);
        door.SetActive(false);
        fuelsel.SetActive(false);
        fuelshutoff.SetActive(false);
        beacon.SetActive(false);
        throttle.SetActive(false);
        mixture.SetActive(false);
        fuelpump.SetActive(false);
       // propellerarea.SetActive(false);
        ignition.SetActive(false);
        //oilpressure.SetActive(false);
        //flaps.SetActive
        //fuel
        preflightcl.SetActive(false);
        enginestart.SetActive(false);
        beforetakeoff.SetActive(false);*/
    }

    // Update is called once per frame
    void Update()
    {
        /*if(preflightcl.activeSelf)
        {
            parkingbreak.SetActive(true);
            /*masteralt.SetActive(true);
            masterbat.SetActive(true);
            avionic1.SetActive(true);
            avionic2.SetActive(true);
            
            flapadj.SetActive(true);
            door.SetActive(true);
            fuelsel.SetActive(true);
            fuelshutoff.SetActive(true);
        }
        if(enginestart.activeSelf)
        {
            masteralt.SetActive(true);
            masterbat.SetActive(true);
            avionic1.SetActive(false);
            avionic2.SetActive(false);
            /*beacon.SetActive(true);
            throttle.SetActive(true);
            mixture.SetActive(true);
            fuelpump.SetActive(true);
            //propellerarea.SetActive(true);
            ignition.SetActive(true);
            //oilpressure.SetActive(true);
            avionic1.SetActive(true);
            avionic2.SetActive(true);
        }
        if(beforetakeoff.activeSelf)
        {
            parkingbreak.SetActive(true);
        }
        */
    }
}

//engine start checklist
//automatically checks off checkboxes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEditor;
using TMPro;

public class startenginecheck : MonoBehaviour
{
    // Start is called before the first frame update
    float delay = 2.2f, curtime = 0;
    public GameObject beacon, throttle, mixpull, fuelp, ignition, flaps, masterbat, masteralt, avionic1, avionic2;
    public TextMeshProUGUI beac, throt, mix, fuel, ign, oilp, flp, master_toggle, av1_toggle , av2_toggle, proprot;
    Quaternion bec, fupump, mag, flap, masterb, mastera, av1, av2;
    Vector3 thrott, mixx;
    bool updates;
    int count = 0, called = 0;
    public GameObject engstart;

    // change ability to start engine
    private void Awake()
    {
        Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");
        updates = true;
        //lock layers except EngineStart and preandstart (and others)
        master_toggle.gameObject.SetActive(false);
        beac.gameObject.SetActive(false);
        throt.gameObject.SetActive(false);
        mix.gameObject.SetActive(false);
        fuel.gameObject.SetActive(false);
        proprot.gameObject.SetActive(false);
        ign.gameObject.SetActive(false);
        oilp.gameObject.SetActive(false);
        av1_toggle.gameObject.SetActive(false);
        av2_toggle.gameObject.SetActive(false);
        flp.gameObject.SetActive(false);

        

        //master activated
        
        //rest deactivated
        
    }

    // Update is called once per frame
    void Update()
    {
        if(updates)
        {
            //change to local rot,local pos
            bec = beacon.transform.rotation;
            fupump = fuelp.transform.rotation;
            mag = ignition.transform.rotation;
            flap = flaps.transform.rotation;
            thrott = throttle.transform.position;
            mixx = mixpull.transform.position;
            masterb = masterbat.transform.rotation;
            mastera = masteralt.transform.rotation;
            av1 = avionic1.transform.rotation;
            av2 = avionic2.transform.rotation;
            if(Time.time - curtime > delay+1.5f)
            {
                master_toggle.gameObject.SetActive(true);
                updates = false;
            }
        }
        if (mastera != masteralt.transform.rotation && master_toggle.gameObject.activeSelf) //beacon light
        {
           
            var mar = master_toggle.transform.GetChild(0).gameObject;
            if (mar.GetComponent<Toggle>().isOn)
            {
                Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");
                //Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                if (Time.time - curtime > delay)
                {
                    count++;
                    curtime = Time.time;
                    master_toggle.gameObject.SetActive(false);
                    beac.gameObject.SetActive(true);
                }
            }
        }

        if (masterb != masterbat.transform.rotation && master_toggle.gameObject.activeSelf) //fuel pump
        {
            var mar = master_toggle.transform.GetChild(0).gameObject;
            if (mar.GetComponent<Toggle>().isOn)
            {
                Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                if (Time.time - curtime > delay)
                {
                    count++;
                    curtime = Time.time;
                    master_toggle.gameObject.SetActive(false);
                    beac.gameObject.SetActive(true);
                }
            }
                
        }

        if (bec != beacon.transform.rotation && beac.gameObject.activeSelf) //beacon light
        {
            var beacon = beac.transform.GetChild(0).gameObject;
            if (beacon.GetComponent<Toggle>().isOn)
            {
                Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                if (Time.time - curtime > delay)
                {
                    count++;
                    curtime = Time.time;
                    beac.gameObject.SetActive(false);
                    throt.gameObject.SetActive(true);
                }
            }    
        }

        if (thrott != throttle.transform.position && throt.gameObject.activeSelf) //throttle
        {
            var throttle_tog = throt.transform.GetChild(0).gameObject;
            if (throttle_tog.GetComponent<Toggle>().isOn)
            {
                Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                if (Time.time - curtime > delay)
                {
                    count++;
                    curtime = Time.time;
                    throt.gameObject.SetActive(false);
                    mix.gameObject.SetActive(true);
                }

            }
        }


        if (mixx != mixpull.transform.position && mix.gameObject.activeSelf) //mixed pull lean
        {
            var mix_t = mix.transform.GetChild(0).gameObject;
            if (mix_t.GetComponent<Toggle>().isOn)
            {
                Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("Magnetos");

                if (Time.time - curtime > delay)
                {
                    count++;
                    curtime = Time.time;
                    mix.gameObject.SetActive(false);
                    fuel.gameObject.SetActive(true);
                }
            }   
        }

        if (fupump != fuelp.transform.rotation && fuel.gameObject.activeSelf) //fuel pump
        {
            var fuel_t = fuel.transform.GetChild(0).gameObject;
            if (fuel_t.GetComponent<Toggle>().isOn)
            {
                Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                if (Time.time - curtime > delay)
                {
                    count++;
                    fuel.gameObject.SetActive(false);
                    proprot.gameObject.SetActive(true);
                    curtime = Time.time;
                }
            }   
        }

        //here manual checking off is needed
        if (proprot.gameObject.activeSelf) //propeller area
        {
            var prop_t = proprot.transform.GetChild(0).gameObject;
            if (prop_t.GetComponent<Toggle>().isOn)
            {
                //count++;
                Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump");

                if (Time.time - curtime > delay)
                {
                    curtime = Time.time;
                    proprot.gameObject.SetActive(false);
                    ign.gameObject.SetActive(true);
                }

            }
        }
       
        
        if (mag != ignition.transform.rotation && ign.gameObject.activeSelf) //magnetic switch
        {
            var ign_t = ign.transform.GetChild(0).gameObject;
            if (ign_t.GetComponent<Toggle>().isOn)
            {
                Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                if (Time.time - curtime > delay)
                {
                    count++;
                    curtime = Time.time;
                    ign.gameObject.SetActive(false);
                    oilp.gameObject.SetActive(true);
                }
            }   
        }

        //here, manually checking off is required
        if (oilp.gameObject.activeSelf) //oil pressure
        {
            var oil_t = oilp.transform.GetChild(0).gameObject;
            if (oil_t.GetComponent<Toggle>().isOn)
            {
                //count++;
                Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                if (Time.time - curtime > delay)
                {
                    curtime = Time.time;
                    oilp.gameObject.SetActive(false);
                    av1_toggle.gameObject.SetActive(true);
                }
            }
        }


        if (av1 != avionic1.transform.rotation && av1_toggle.gameObject.activeSelf) //beacon light
        {
            var av1t = av1_toggle.transform.GetChild(0).gameObject;
            if (av1t.GetComponent<Toggle>().isOn)
            {
                Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                if (Time.time - curtime > delay)
                {
                    count++;
                    curtime = Time.time;
                    av1_toggle.gameObject.SetActive(false);
                    av2_toggle.gameObject.SetActive(true);
                }
            }   
        }

        if (av2 != avionic2.transform.rotation && av2_toggle.gameObject.activeSelf) //fuel pump
        {
            var av2t = av2_toggle.transform.GetChild(0).gameObject;
            if (av2t.GetComponent<Toggle>().isOn)
            {


                Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                if (Time.time - curtime > delay)
                {
                    count++;
                    curtime = Time.time;
                    av2_toggle.gameObject.SetActive(false);
                    flp.gameObject.SetActive(true);
                }
            }   
        }

        if (flap != flaps.transform.rotation && flp.gameObject.activeSelf) //flap
        {
            var flp_t = flp.transform.GetChild(0).gameObject;
            if (flp_t.GetComponent<Toggle>().isOn)
            {
                if (Time.time - curtime > delay)
                {
                    count++;
                    flp.gameObject.SetActive(false);
                }
            }    
        }
        //

        if (called == 0 && count >= 9)
        {
            called++;
            deeactivate();
        }
    }

    void deeactivate()
    {
        var boolean = GameObject.Find("done"); //engstart
        boolean.GetComponent<Toggle>().isOn = true;
        engstart.SetActive(false);
    }
}

//preflight checklist script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class checkelesinlist : MonoBehaviour
{
    // Start is called before the first frame update
    float delay = 2.5f, curtime;
    public GameObject parking, masterbat, masteralt, flap, av1, av2, select, shutoff;
    public TextMeshProUGUI par, mason, fl, a1on, a2on, a1off, a2off, masoff, sel, soff, fuelq, dor; //text
    Vector3 p1, f1, sf1;
    Quaternion  mb1, ma1, av11, av21, s1;
    //public Quaternion d1, doro1;
    // public Transform doro1;
    bool master_setTransform, avionic_setTransform;
    int count = 0, called = 0;
    public GameObject enginestart, preflight;
    float _time;
    private void Awake()
    {
        _time = 0;
        master_setTransform = avionic_setTransform = false;
        enginestart.SetActive(false);
        mason.gameObject.SetActive(false);
        fl.gameObject.SetActive(false);
        fuelq.gameObject.SetActive(false);
        a1on.gameObject.SetActive(false);
        a2on.gameObject.SetActive(false);
        a1off.gameObject.SetActive(false);
        a2off.gameObject.SetActive(false);
        masoff.gameObject.SetActive(false);
        dor.gameObject.SetActive(false);
        sel.gameObject.SetActive(false);
        soff.gameObject.SetActive(false);

        //lock all layers 
        Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBrake") | 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");
        
        //setting up initial transform
        p1 = parking.transform.position;
        mb1 = masterbat.transform.rotation;
        ma1 = masteralt.transform.rotation;
        f1 = flap.transform.position;
       // fq1 = fuelqt.transform;
        av11 = av1.transform.rotation;
        av21 = av2.transform.rotation;
        s1 = select.transform.rotation;
        sf1 = shutoff.transform.position;
        //doro1 = door.transform;
        //parking break - first one to go
        par.gameObject.SetActive(true);
        //inactive
        
    }

    // Update is called once per frame
    void Update()
    {
        _time = _time + 1f * Time.deltaTime;

        //unlocking parking brake layer
        if(par.gameObject.activeSelf && par.transform.GetChild(0).gameObject.GetComponent<Toggle>().isOn == false)
        {
            Tools.lockedLayers = 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

        }
        if (p1 != parking.transform.position && par.gameObject.activeSelf) //parking
        {
            var park_toggle = par.transform.GetChild(0).gameObject;
            if (park_toggle.GetComponent<Toggle>().isOn)
            {

                if (_time - curtime > delay)
                {
                    count++;
                    //activate master
                    curtime = Time.time;
                    Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBrake") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                    mason.gameObject.SetActive(true);
                    par.gameObject.SetActive(false);
                }
            }
        }

        if(mb1 != masterbat.transform.rotation && mason.gameObject.activeSelf) //master battery
        {
            var mas_toggle = mason.transform.GetChild(0).gameObject;
            if (mas_toggle.GetComponent<Toggle>().isOn)
            {
                //while (Time.time - curtime < delay) ;
                if (Time.time - curtime > delay + 1f)
                {
                    count++;
                    curtime = Time.time;
                    //curtime = Time.time;
                    Tools.lockedLayers = 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                    //fl.gameObject.SetActive(true);
                    master_setTransform = true;
                    mason.gameObject.SetActive(false);

                }
            }   
            
        }
        if (ma1 != masteralt.transform.rotation && mason.gameObject.activeSelf) //master alternate
        {
            var mas_toggle = mason.transform.GetChild(0).gameObject;
            if (mas_toggle.GetComponent<Toggle>().isOn)
            {
                ma1 = masteralt.transform.rotation;
                //while (Time.time - curtime < delay) ;
                if (Time.time - curtime > delay + 1f)
                {
                    count++;
                    //flap.SetActive(true);
                    curtime = Time.time;
                    Tools.lockedLayers = 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                    //fl.gameObject.SetActive(true);
                    master_setTransform = true;
                    mason.gameObject.SetActive(false);
                }
            }
        }
        //to save master transform
        if(master_setTransform)
        {
            ma1 = masteralt.transform.rotation;
            mb1 = masterbat.transform.rotation;
            if (Time.time - curtime > delay+1f)
            {
                curtime = Time.time;
                master_setTransform = false;
                fl.gameObject.SetActive(true);
            }
                
        }
        if (f1 != flap.transform.position && fl.gameObject.activeSelf) //flap
        {
            var flap_toggle = fl.transform.GetChild(0).gameObject;
            if (flap_toggle.GetComponent<Toggle>().isOn)
            {
                //while (Time.time - curtime < delay) ;
                master_setTransform = false;
                if (Time.time - curtime > delay + 1f)
                {
                    curtime = Time.time;
                    count++;
                    //av1.SetActive(true);
                    Tools.lockedLayers = 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                    fuelq.gameObject.SetActive(true);
                    fl.gameObject.SetActive(false);
                }
            }
        }

        //manual checking off
        if(fuelq.gameObject.activeSelf)
        {
            var fuel_toggle = fuelq.transform.GetChild(0).gameObject;
            if (fuel_toggle.GetComponent<Toggle>().isOn)
            if (Time.time - curtime > delay+1f)
            {
                curtime = Time.time;
                Tools.lockedLayers = 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                a1on.gameObject.SetActive(true);
                fuelq.gameObject.SetActive(false);
            }
            
            
        }
        if (av11 != av1.transform.rotation && a1on.gameObject.activeSelf) //avionic 1
        {
            var a1_toggle = a1on.transform.GetChild(0).gameObject;
            if (a1_toggle.GetComponent<Toggle>().isOn)
            {
                //while (Time.time - curtime < delay) ;
                if (Time.time - curtime > delay + 1f)
                {
                    curtime = Time.time;
                    count++;
                    //av2.SetActive(true);
                    a2on.gameObject.SetActive(true);

                    a1on.gameObject.SetActive(false);
                }
            }
            
        }

        if (av21 != av2.transform.rotation && a2on.gameObject.activeSelf) //avionic 2
        {
            var a2_toggle = a2on.transform.GetChild(0).gameObject;
            if (a2_toggle.GetComponent<Toggle>().isOn)
            {
                a2_toggle.gameObject.SetActive(false);
                //while (Time.time - curtime < 4*delay) ;
                Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                if (Time.time - curtime > 2 * delay)
                {
                    curtime = Time.time;
                    count++;
                    //av2.SetActive(true);
                    //a1off.gameObject.SetActive(true);
                    avionic_setTransform = true;
                    av21 = av2.transform.rotation;
                    a2on.gameObject.SetActive(false);
                    //a2on.gameObject.SetActive(false);
                }
            }
            
        }
        if(avionic_setTransform)
        {

            av11 = av1.transform.rotation;
            av21 = av2.transform.rotation;
            Tools.lockedLayers = 1 << LayerMask.NameToLayer("parkingBreak") |1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

            if (Time.time - curtime > delay + 1f)
            {
                curtime = Time.time;
                avionic_setTransform = false;
                a1off.gameObject.SetActive(true);
                
            }
        }
        if (av11 != av1.transform.rotation && a1off.gameObject.activeSelf) //avionic 1
        {
            var a1_toggle = a1off.transform.GetChild(0).gameObject;
            if (a1_toggle.GetComponent<Toggle>().isOn)
            {
                //while (Time.time - curtime < delay) ;
                if (Time.time - curtime > delay + 1f)
                {
                    curtime = Time.time;
                    count++;
                    //av2.SetActive(true);
                    a2off.gameObject.SetActive(true);
                    a1off.gameObject.SetActive(false);
                }
            }

        }

        if (av21 != av2.transform.rotation && a2off.gameObject.activeSelf) //avionic 2
        {
            var a2_toggle = a2off.transform.GetChild(0).gameObject;
            if (a2_toggle.GetComponent<Toggle>().isOn)
            {
                //while (Time.time - curtime < delay) ;
                if (Time.time - curtime > delay + 1f)
                {
                    curtime = Time.time;
                    count++;
                    //av2.SetActive(true);
                    Tools.lockedLayers = 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                    masoff.gameObject.SetActive(true);
                    a2off.gameObject.SetActive(false);
                }
            }

        }
        if (mb1 != masterbat.transform.rotation && masoff.gameObject.activeSelf) //master battery
        {
            var mas_toggle = masoff.transform.GetChild(0).gameObject;
            if (mas_toggle.GetComponent<Toggle>().isOn)
            {
                //while (Time.time - curtime < delay) ;
                if (Time.time - curtime > delay + 1f)
                {
                    count++;
                    curtime = Time.time;
                    Tools.lockedLayers = 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                    dor.gameObject.SetActive(true);
                    masoff.gameObject.SetActive(false);

                }
            }

        }
        if (ma1 != masteralt.transform.rotation && masoff.gameObject.activeSelf) //master alternate
        {
            var mas_toggle = masoff.transform.GetChild(0).gameObject;
            if (mas_toggle.GetComponent<Toggle>().isOn)
            {
                //while (Time.time - curtime < delay) ;
                if (Time.time - curtime > delay + 1f)
                {
                    count++;
                    //flap.SetActive(true);
                    Tools.lockedLayers = 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelSelect") | 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                    curtime = Time.time;
                    dor.gameObject.SetActive(true);
                    masoff.gameObject.SetActive(false);
                }
            }
        }

        //manual checking off 
        if (dor.gameObject.activeSelf) //avionic 2
        {
            var d_toggle = dor.transform.GetChild(0).gameObject;
            if(d_toggle.GetComponent<Toggle>().isOn) //= true;
            //while (Time.time - curtime < delay) ;
            if (Time.time - curtime > delay+1f)
            {
                curtime = Time.time;
                count++;
                //select.SetActive(true);
                sel.gameObject.SetActive(true);
                dor.gameObject.SetActive(false);
            }
            
            
        }

        if (s1 != select.transform.rotation && sel.gameObject.activeSelf) //avionic 2
        {
            var sel_toggle = sel.transform.GetChild(0).gameObject;
            sel_toggle.GetComponent<Toggle>().isOn = true;
            //while (Time.time - curtime < delay) ;
            if (Time.time - curtime > delay+1f)
            {
                curtime = Time.time;
                count++;
                //shutoff.SetActive(true);
                Tools.lockedLayers = 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("parkingBreak") | 1 << LayerMask.NameToLayer("fuelShutoffValve") | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                soff.gameObject.SetActive(true);
                sel.gameObject.SetActive(false);
            }
            
            
        }

        if (sf1 != shutoff.transform.position && soff.gameObject.activeSelf) //fuel shutoff
        {
            var soff_toggle = soff.transform.GetChild(0).gameObject;
            soff_toggle.GetComponent<Toggle>().isOn = true;
            //while (Time.time - curtime < delay) ;
            if (Time.time - curtime > delay+1f)
            {
                curtime = Time.time;
                count++;
                Tools.lockedLayers = 1 << LayerMask.NameToLayer("Master") | 1 << LayerMask.NameToLayer("Avionics") | 1 << LayerMask.NameToLayer("Flap") | 1 << LayerMask.NameToLayer("fuelSelect")  | 1 << LayerMask.NameToLayer("Beacon") | 1 << LayerMask.NameToLayer("Throttle") | 1 << LayerMask.NameToLayer("Mixture") | 1 << LayerMask.NameToLayer("fuelPump") | 1 << LayerMask.NameToLayer("Magnetos");

                soff.gameObject.SetActive(false);
            }
            
        }
       

        if (called == 0 && count >= 11)
        {
            called++;
            activate2();
        }
    }

    void activate2()
    {
        enginestart.SetActive(true); //confirmation window for enginestart is set to true before preflight checklist object is deactivated
        var boolean = GameObject.Find("done"); //preflight ob
        boolean.GetComponent<Toggle>().isOn = true;
        preflight.SetActive(false);
    }
}

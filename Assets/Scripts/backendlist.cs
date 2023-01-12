using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backendlist : MonoBehaviour
{
    public Toggle[] pre;
    public Toggle[] starte;
    public Toggle[] before;

    //private bool[] pre_bool, starte_bool, before_bool;
    void Start()
    {
        //to be shifted to game manager
        DontDestroyOnLoad(this);
    }

    // preflight
    public bool getpreflight_parkingbreak()
    {
        backendlist bl = new backendlist();
        return bl.pre[0].GetComponent<Toggle>().isOn;
    }
    public bool getpreflight_masteron()
    {
        backendlist bl = new backendlist();
        return bl.pre[1].GetComponent<Toggle>().isOn;
    }
    public bool getpreflight_flapadj()
    {
        backendlist bl = new backendlist();
        return bl.pre[2].GetComponent<Toggle>().isOn;
    }
    public bool getpreflight_fuelq()
    {
        backendlist bl = new backendlist();
        return bl.pre[3].GetComponent<Toggle>().isOn;
    }
    public bool getpreflight_av1on()
    {
        backendlist bl = new backendlist();
        return bl.pre[4].GetComponent<Toggle>().isOn;
    }
    public bool getpreflight_av2on()
    {
        backendlist bl = new backendlist();
        return bl.pre[5].GetComponent<Toggle>().isOn;
    }
    public bool getpreflight_av1off()
    {
        backendlist bl = new backendlist();
        return bl.pre[6].GetComponent<Toggle>().isOn;
    }
    public bool getpreflight_av2off()
    {
        backendlist bl = new backendlist();
        return bl.pre[7].GetComponent<Toggle>().isOn;
    }
    public bool getpreflight_masteroff()
    {
        backendlist bl = new backendlist();
        return bl.pre[8].GetComponent<Toggle>().isOn;
    }
    public bool getpreflight_door()
    {
        backendlist bl = new backendlist();
        return bl.pre[9].GetComponent<Toggle>().isOn;
    }
    public bool getpreflight_fuelsel()
    {
        backendlist bl = new backendlist();
        return bl.pre[10].GetComponent<Toggle>().isOn;
    }
    public bool getpreflight_fuelshutoff()
    {
        backendlist bl = new backendlist();
        return bl.pre[11].GetComponent<Toggle>().isOn;
    }

    // engine start
    public bool getenginestart_master()
    {
        backendlist bl = new backendlist();
        return bl.starte[0].GetComponent<Toggle>().isOn;
    }
    public bool getenginestart_beacon()
    {
        backendlist bl = new backendlist();
        return bl.starte[1].GetComponent<Toggle>().isOn;
    }
    public bool getenginestart_throttle()
    {
        backendlist bl = new backendlist();
        return bl.starte[2].GetComponent<Toggle>().isOn;
    }
    public bool getenginestart_mixture()
    {
        backendlist bl = new backendlist();
        return bl.starte[3].GetComponent<Toggle>().isOn;
    }
    public bool getenginestart_fuelpump()
    {
        backendlist bl = new backendlist();
        return bl.starte[4].GetComponent<Toggle>().isOn;
    }
    public bool getenginestart_proparea()
    {
        backendlist bl = new backendlist();
        return bl.starte[5].GetComponent<Toggle>().isOn;
    }
    public bool getenginestart_ign()
    {
        backendlist bl = new backendlist();
        return bl.starte[6].GetComponent<Toggle>().isOn;
    }
    public bool getenginestart_oilp()
    {
        backendlist bl = new backendlist();
        return bl.starte[7].GetComponent<Toggle>().isOn;
    }
    public bool getenginestart_av1()
    {
        backendlist bl = new backendlist();
        return bl.starte[8].GetComponent<Toggle>().isOn;
    }
    public bool getenginestart_av2()
    {
        backendlist bl = new backendlist();
        return bl.starte[9].GetComponent<Toggle>().isOn;
    }
    public bool getenginestart_flaps()
    {
        backendlist bl = new backendlist();
        return bl.starte[10].GetComponent<Toggle>().isOn;
    }

    //before takeoff
    public bool getbeforetakeoff_parkingbreak()
    {
        backendlist bl = new backendlist();
        return bl.before[0].GetComponent<Toggle>().isOn;
    }
    public bool getbeforetakeoff_fuelquant()
    {
        backendlist bl = new backendlist();
        return bl.before[1].GetComponent<Toggle>().isOn;
    }
}

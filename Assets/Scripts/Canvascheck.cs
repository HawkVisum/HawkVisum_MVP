using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Canvascheck : MonoBehaviour
{
    private backendlist check;
    private TimeRecorder values;
    bool parkingbreak;
    bool masterswitchon;
    bool flapadjustment;
    bool fuelquantity;
    bool Av1switchon;
    bool Av2switchon;
    bool Av1switchoff;
    bool Av2switchoff;
    bool masterswitchoff;
    bool Doors;
    bool Fuelselector;
    bool ShutValue;
    bool Masterswitch;
    bool beaconlightswitch;
    bool throttle;
    bool mpl;
    bool proparea;
    bool fuelp;
    bool igniswitch;
    bool oilp;
    bool av1;
    bool av2;
    bool flaps;
    bool parkbr;
    bool fuelquant;

    public GameObject parkingb;
    public GameObject masteron;
    public GameObject flapadju;
    public GameObject fuelquan;
    public GameObject Av1swion;
    public GameObject Av2swion;
    public GameObject Av1swioff;
    public GameObject Av2swioff;
    public GameObject masteroff;
    public GameObject Door;
    public GameObject Fuelselec;
    public GameObject ShutVal;
    public GameObject Masterswi;
    public GameObject beaconlight;
    public GameObject throt;
    public GameObject mp;
    public GameObject propar;
    public GameObject fuel;
    public GameObject igniswi;
    public GameObject oil;
    public GameObject av_1;
    public GameObject av_2;
    public GameObject flap;
    public GameObject park;
    public GameObject fuelqua;

    public TextMeshProUGUI speedval, heightval, landval, takeoffval, timemin, timehr;
    public float speed, height, timetaken, takeoffDistance, landDistance;
    string Y = "ON";
    string N = "OFF";
    // Start is called before the first frame update
    void Start()
    {
        check = GameObject.Find("carryoverbackend").GetComponent<backendlist>();
        values = GameObject.Find("carryoverbackend").GetComponent<TimeRecorder>();
    }

    // Update is called once per frame
    void Update()
    {
        parkingbreak = check.getpreflight_parkingbreak();
        if (parkingbreak)
        {
            parkingb.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            parkingb.GetComponent<Text>().text = "" + N;
        }
        masterswitchon = check.getpreflight_masteron();
        if (masterswitchon)
        {
            masteron.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            masteron.GetComponent<Text>().text = "" + Y;
        }
        flapadjustment = check.getpreflight_flapadj();
        if (flapadjustment)
        {
            flapadju.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            flapadju.GetComponent<Text>().text = "" + N;
        }
        fuelquantity = check.getpreflight_fuelq();
        if (fuelquantity)
        {
            fuelquan.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            fuelquan.GetComponent<Text>().text = "" + N;
        }
        Av1switchon = check.getpreflight_av1on();
        if (Av1switchon)
        {
            Av1swion.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            Av1swion.GetComponent<Text>().text = "" + N;
        }
        Av2switchon = check.getpreflight_av2on();
        if (Av2switchon)
        {
            Av2swion.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            Av2swion.GetComponent<Text>().text = "" + N;
        }
        //
        Av1switchoff = check.getpreflight_av1off();
        if (Av1switchoff)
        {
            Av1swioff.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            Av1swioff.GetComponent<Text>().text = "" + N;
        }
        Av2switchoff = check.getpreflight_av2off();
        if (Av2switchoff)
        {
            Av2swioff.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            Av2swioff.GetComponent<Text>().text = "" + N;
        }
        masterswitchoff = check.getpreflight_masteroff();
        if (masterswitchoff)
        {
            masteroff.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            masteroff.GetComponent<Text>().text = "" + Y;
        }
        Doors = check.getpreflight_door();
        if (Doors)
        {
            Door.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            Door.GetComponent<Text>().text = "" + N;
        }
        Fuelselector = check.getpreflight_fuelsel();
        if (Fuelselector)
        {
            Fuelselec.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            Fuelselec.GetComponent<Text>().text = "" + N;
        }
        ShutValue = check.getpreflight_fuelshutoff();
        if (ShutValue)
        {
            ShutVal.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            ShutVal.GetComponent<Text>().text = "" + N;
        }
        Masterswitch = check.getenginestart_master();
        if (Masterswitch)
        {
            Masterswi.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            Masterswi.GetComponent<Text>().text = "" + N;
        }
        beaconlightswitch = check.getenginestart_beacon();
        if (beaconlightswitch)
        {
            beaconlight.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            beaconlight.GetComponent<Text>().text = "" + N;
        }
        throttle = check.getenginestart_throttle();
        if (throttle)
        {
            throt.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            throt.GetComponent<Text>().text = "" + N;
        }
        mpl = check.getenginestart_mixture();
        if (mpl)
        {
            mp.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            mp.GetComponent<Text>().text = "" + N;
        }
        proparea = check.getenginestart_proparea();
        if (proparea)
        {
            propar.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            propar.GetComponent<Text>().text = "" + N;
        }
        fuelp = check.getenginestart_fuelpump();
        if (fuelp)
        {
            fuel.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            fuel.GetComponent<Text>().text = "" + N;
        }
        igniswitch = check.getenginestart_ign();
        if (igniswitch)
        {
            igniswi.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            igniswi.GetComponent<Text>().text = "" + N;
        }
        oilp = check.getenginestart_oilp();
        if (oilp)
        {
            oil.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            oil.GetComponent<Text>().text = "" + N;
        }
        av1 = check.getenginestart_av1();
        if (av1)
        {
            av_1.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            av_1.GetComponent<Text>().text = "" + N;
        }
        av2 = check.getenginestart_av2();
        if (av2)
        {
            av_2.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            av_2.GetComponent<Text>().text = "" + N;
        }
        flaps = check.getenginestart_flaps();
        if (flaps)
        {
            flap.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            flap.GetComponent<Text>().text = "" + N;
        }
        parkbr = check.getbeforetakeoff_parkingbreak();
        if (parkbr)
        {
            park.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            park.GetComponent<Text>().text = "" + N;
        }
        fuelquant = check.getbeforetakeoff_fuelquant();
        if (fuelquant)
        {
            fuelqua.GetComponent<Text>().text = "" + Y;
        }
        else
        {
            fuelqua.GetComponent<Text>().text = "" + N;
        }
        speedval.GetComponent<Text>().text = values.speed.ToString();
        heightval.GetComponent<Text>().text = values.height.ToString();
        landval.GetComponent<Text>().text = values.land.ToString();
        takeoffval.GetComponent<Text>().text = values.takeoff.ToString();
        timehr.GetComponent<Text>().text = values.hour.ToString();
        timemin.GetComponent<Text>().text = values.min.ToString();

    }
}
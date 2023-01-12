using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRecorder : MonoBehaviour
{
    public int hour = 0;
    public int min = 0;
    public float sec = 0f;
    /*public GameObject minbox;
    public GameObject hourbox;*/
    public float takeoff, land, speed, height;
    [SerializeField] GameObject AirCraft;
     void Start()
     {
        DontDestroyOnLoad(this);
     }

    public void Update()
    {
        sec += Time.deltaTime;

        if (sec > 59)
        {
            sec = 0;
            min += 1;
        }
        /*if (min >= 0)
        {
            minbox.GetComponent<Text>().text = "" + min + "";
        }*/

        if (min > 59)
        {
            min = 0;
            hour += 1;
        }
        /*if (hour >= 0)
        {
            hourbox.GetComponent<Text>().text = "" + hour + "";
        }*/
        land = AirCraft.GetComponent<LD_Script>().distance;
        takeoff = AirCraft.GetComponent<LandingAndTakeoffDistance>().distance;
        speed = AirCraft.GetComponent<speed>().maxspeed;
        height = AirCraft.GetComponent<height>().maxheight;
    }
}


//changes speed at taxiway

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sppedyaw_change : MonoBehaviour
{
    //public AirCraft airp;
    //public AirplaneController airc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void entertrigger(Collider airpl)
    {
        if (airpl.gameObject.CompareTag("Airplane"))
        {
            airpl.gameObject.GetComponent<AircraftPhysics>().maxSpeed = 10;
            //airpl.gameObject.GetComponent<AirplaneController>().yawControlSensitivity = 1.2f;
            //airp.GetComponent<AircraftePhysics>().maxSpeed = 10; airp.GetComponent<AirplanePhysics>().yawControlSensitivity = 1.2f;
        }
    }
}

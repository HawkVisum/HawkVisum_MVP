//collider to activate before takeoff popup
//and change spped at runway

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class takeofactivatescript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject popuptake, checklisttake;
    void Start()
    {
        popuptake.SetActive(false);
        checklisttake.SetActive(false);
    }

    // Update is called once per frame
    void OnTrigger(Collider Player)
    {
        var done = checklisttake.transform.GetChild(3);
        if(Player.gameObject.CompareTag("Airplane"))
        {
            Debug.Log("collider hit!");
            Player.gameObject.GetComponent<AircraftPhysics>().maxSpeed = 165;
            //Player.gameObject.GetComponent<AirplaneController>().yawControlSensitivity = 0.2f;
            if (done.GetComponent<Toggle>().isOn == false)
                popuptake.SetActive(true);
        }
            
        
    }

    /*void OffTrigger(Collider Player)
    {
        if (Player.gameObject.CompareTag("Airplane"))
            popuptake.SetActive(false);
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnIndicator : MonoBehaviour
{
    [SerializeField] GameObject AirCraft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float leftright;

        if (AirCraft.transform.localEulerAngles.z < 180 && AirCraft.transform.localEulerAngles.z > 10)
        {
            leftright = -21f;
        }
        else if (AirCraft.transform.localEulerAngles.z > 180 && AirCraft.transform.localEulerAngles.z < 350)
            leftright = 21f;
        else
            leftright = 0f;
        transform.localEulerAngles = new Vector3(0f, 0f, leftright);
    }
}

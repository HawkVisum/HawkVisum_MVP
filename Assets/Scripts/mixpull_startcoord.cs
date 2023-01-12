using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mixpull_startcoord : MonoBehaviour
{
    // Start is called before the first frame update
    public float start_mix;
    public GameObject knobmix;
    void Start()
    {
        start_mix = knobmix.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

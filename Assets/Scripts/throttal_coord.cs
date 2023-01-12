using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throttal_coord : MonoBehaviour
{
    // Start is called before the first frame update
    public float throt_st;
    public GameObject thrott;
    void Start()
    {
        throt_st = thrott.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

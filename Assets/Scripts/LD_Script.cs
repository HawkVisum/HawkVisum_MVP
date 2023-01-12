using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LD_Script : MonoBehaviour
{
    public GameObject lastHit;
    public Vector3 collision = Vector3.zero;
    public float distance;
    float LandedHeight;
    float Height;
    Vector3 oldpos;
    bool tookoff = false;
    //public GameObject LTF;




    void Start()
    {
        var ray = new Ray(this.transform.position, -this.transform.up);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "ground")
            {
                lastHit = hit.transform.gameObject;
                collision = hit.point;
                LandedHeight = transform.position.y - hit.collider.transform.position.y;
                oldpos = transform.position;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        var ray = new Ray(this.transform.position, -this.transform.up);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag != "ground")
            {
                lastHit = hit.transform.gameObject;
                collision = hit.point;
                Height = transform.position.y - hit.collider.transform.position.y;
            }
        }
        if ((Height - 0.1f) > LandedHeight)
        {
            tookoff = true;
        }
        distance += disCovered(tookoff);
        //LTF.GetComponent<Text>().text = "" + distance + "";


    }
    float disCovered(bool tookoff)
    {
        float dis = 0f;
        if (!tookoff)
        {
            dis = Vector3.Distance(transform.position, oldpos);
            oldpos = transform.position;
        }
        return dis;
    }
}

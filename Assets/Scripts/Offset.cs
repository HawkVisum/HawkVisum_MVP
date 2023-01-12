using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltimateXR.Avatar;

public class Offset : MonoBehaviour
{
    [SerializeField] GameObject OffSet;
    [SerializeField] float height = 1.1f;
    Vector3 headpos=new Vector3(0,0,0);
    Vector3 rigpos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        headpos = UxrAvatar.LocalAvatar.CameraPosition;
        rigpos = UxrAvatar.LocalAvatar.CameraFloorPosition;

    }

    private void OnTriggerEnter(Collider other)
    {
        headpos = UxrAvatar.LocalAvatar.CameraPosition;
        rigpos = UxrAvatar.LocalAvatar.CameraFloorPosition;
        float offset = height - (headpos.y - rigpos.y);
        OffSet.transform.Translate(OffSet.transform.position.x, OffSet.transform.position.y + offset, OffSet.transform.position.z);
    }

}

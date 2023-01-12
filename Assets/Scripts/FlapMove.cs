using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapMove : MonoBehaviour
{
    [SerializeField]
    FlapHandle flapHandle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector3 = transform.localRotation.eulerAngles;
        vector3.x = flapHandle.flapPosPer() * 45;
        transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(vector3) ,Time.deltaTime * 0.15f);
    }
}

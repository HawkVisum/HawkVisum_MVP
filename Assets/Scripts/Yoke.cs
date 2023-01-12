using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yoke : MonoBehaviour
{
    [SerializeField] Transform Yoke_start;
    [SerializeField] Transform Yoke_End;
    [SerializeField] Transform yoke;
    [SerializeField] float Yoke_Left;
    [SerializeField] float Yoke_Right;

    void Start()
    {

    }

    void Update()
    {
        yokeposper();
        yokerotper();
    }

    public float yokeposper()
    {
        float ans;
        float temp = Mathf.InverseLerp(Yoke_start.localPosition.z, Yoke_End.localPosition.z, yoke.localPosition.z);
        ans = (temp * 2) - 1;
        return ans;
    }
    public float yokerotper()
    {
        float ans;

        Vector3 vector3 = transform.localEulerAngles;
        if (vector3.z > 180)
        {
            vector3.z = vector3.z - 360;
        }
        float temp = Mathf.InverseLerp(Yoke_Left, Yoke_Right, vector3.z);
        ans = (temp * 2) - 1;
        return ans;
    }
}

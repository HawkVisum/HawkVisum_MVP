using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapHandle : MonoBehaviour
{
    [SerializeField] Transform Flap_start;
    [SerializeField] Transform Flap_End;
    [SerializeField] Transform flap;

    void Start()
    {

    }

    void Update()
    {

    }

    public float flapPosPer()
    {
        float ans = Mathf.InverseLerp(Flap_start.localPosition.y, Flap_End.localPosition.y, flap.localPosition.y);
        return ans;
    }
}

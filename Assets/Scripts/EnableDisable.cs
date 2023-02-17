using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    [SerializeField]
    GameObject[] Lights;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Enabledisable()
    {
        foreach(GameObject light in Lights)
        {
            light.SetActive(!light.activeSelf);
        }
    }
}

//to check back to checklist if user has previously exited that window

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getbacktolist : MonoBehaviour
{
    // Start is called before the first frame update
    //int donepreflight=0, doneenginestart=0, donebeforetakeoff=0;
    [SerializeField] private GameObject preflight, enginestart, beforetakeoff, button;
    [SerializeField] private Toggle pref, engstart, beforetake;
    void Start()
    {
        button.SetActive(false);
    }

    void update()
    {
        if (beforetake.GetComponent<Toggle>().isOn == true)
            button.SetActive(false);
    }
    // Update is called once per frame
    public void OnClick()
    {
        //if preflight checklist is not yet done

        if (pref.GetComponent<Toggle>().isOn == false)
        {
            if (preflight.activeSelf == false)
                preflight.SetActive(true);
        }
        else if (engstart.GetComponent<Toggle>().isOn == false)
        {
            if (enginestart.activeSelf == false)
                enginestart.SetActive(true);
        }

        else if (beforetake.GetComponent<Toggle>().isOn == false)
        {
            if (beforetakeoff.activeSelf == false)
                beforetakeoff.SetActive(true);
        }
        
    }
}

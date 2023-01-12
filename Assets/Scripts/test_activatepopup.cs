using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_activatepopup : MonoBehaviour
{
    public GameObject popuppre, checklistpre, popupstart, checkliststart, popuptake, checklisttake;

    void Start()
    {
        popuppre.SetActive(true);
        checklistpre.SetActive(false);
        popupstart.SetActive(false);
        checkliststart.SetActive(false);
        popuptake.SetActive(false);
        checklisttake.SetActive(false);
    }

    // Update is called once per frame

    public void OnClickNo()
    {
        popuppre.SetActive(false);
    }

    public void OnClickYes()
    {
        checklistpre.SetActive(true);
        popuppre.SetActive(false);
    }

    public void onclickyes_es()
    {
        checkliststart.SetActive(true);
        popupstart.SetActive(false);
    }

    public void OnClickNo_es()
    {
        popupstart.SetActive(false);
    }

    public void onclickyes_take()
    {
        checklisttake.SetActive(true);
        popuptake.SetActive(false);
    }

    public void OnClickNo_take()
    {
        popuptake.SetActive(false);
    }
}

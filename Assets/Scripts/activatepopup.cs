//activates checklists sequentially 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activatepopup : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject popuppre, checklistpre, popupstart, checkliststart, popuptake, checklisttake, endsim;
    
    void Start()
    {
        popuppre.SetActive(true);
        checklistpre.SetActive(false);
        popupstart.SetActive(false);
        checkliststart.SetActive(false);
        popuptake.SetActive(false);
        checklisttake.SetActive(false);
        endsim.SetActive(false);
        
    }
    
    // Update is called once per frame

    //change the trigger function

    /*void OnTriggerEnter(Collider Player)
    {
        if(Player.gameObject.tag == "Player")
        {
            popuppre.SetActive(true);
        }
    }*/

    /*void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            popuppre.SetActive(false);
        }
    }*/

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

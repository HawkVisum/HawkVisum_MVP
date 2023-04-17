using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NextChecklistItem : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject thisTextbox;
    [SerializeField]
    GameObject nextTextbox;
    [SerializeField]
    int checklist; //1=Pre - Flight Checklist, 2=Engine Start Checklist, 3=Pre - Taxi Checklist , 4=On - Runway Checklist, 5=After Landing Checklist
    GameManager gameManager;



    private void Start()
    {
        gameManager = GameManager.instance;
    }

    public void YesButtonClicked()
    {
        thisTextbox.SetActive(false);


        if (checklist == 1)
            gameManager.PreFlightChecklist(thisTextbox.name);
        else if (checklist == 2)
            gameManager.EngineStartChecklist(thisTextbox.name);
        else if (checklist == 3)
            gameManager.PreTaxiChecklist(thisTextbox.name);
        else if (checklist == 4)
            gameManager.OnRunwayChecklist(thisTextbox.name);
        else if (checklist == 5)
            gameManager.AfterLandingChecklist(thisTextbox.name);


        if (nextTextbox)
            nextTextbox.SetActive(true);

    }



}

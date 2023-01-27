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

    Toggle toggle;
    TextMeshPro textMeshPro;


    private void Start()
    {
        gameManager = GameManager.instance;
        toggle = GetComponentInChildren<Toggle>();
        textMeshPro = GetComponent<TextMeshPro>();
    }

    public void YesButtonClicked()
    {
        thisTextbox.SetActive(false);
        if (nextTextbox)
            nextTextbox.SetActive(true);
        switch(checklist)
        {
            case 1:
                gameManager.PreFlightChecklist(toggle, textMeshPro);
                break;
            case 2:
                gameManager.EngineStartChecklist(toggle, textMeshPro);
                break;
            case 3:
                gameManager.PreTaxiChecklist(toggle, textMeshPro);
                break;
            case 4:
                gameManager.OnRunwayChecklist(toggle, textMeshPro);
                break;
            case 5:
                gameManager.AfterLandingChecklist(toggle, textMeshPro);
                break;
            default:
                string s = thisTextbox.name;
                Debug.Log("choose checklist between 1 to 5 in") ;
                Debug.Log(s);
                break;
        }
    }



}

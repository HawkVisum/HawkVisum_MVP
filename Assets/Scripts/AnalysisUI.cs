using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnalysisUI : MonoBehaviour
{
    [SerializeField]
    GameObject[] gameObjects;
    [SerializeField]
    int checklist;
    GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;

        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setCheklist()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            switch (checklist)
            {
                case 1:
                    gameObjects[i].GetComponent<TextMeshProUGUI>().text = gameManager.PreFlightCheckList[i].text;
                    gameObjects[i].GetComponentInChildren<Toggle>().isOn = gameManager.PreFlightCheckList[i].WasTicked;
                    break;
                case 2:
                    gameObjects[i].GetComponent<TextMeshProUGUI>().text = gameManager.EngineStartCheckList[i].text;
                    gameObjects[i].GetComponentInChildren<Toggle>().isOn = gameManager.EngineStartCheckList[i].WasTicked;
                    break;
                case 3:
                    gameObjects[i].GetComponent<TextMeshProUGUI>().text = gameManager.PreTaxiCheckList[i].text;
                    gameObjects[i].GetComponentInChildren<Toggle>().isOn = gameManager.PreTaxiCheckList[i].WasTicked;
                    break;
                case 4:
                    gameObjects[i].GetComponent<TextMeshProUGUI>().text = gameManager.OnRunwayCheckList[i].text;
                    gameObjects[i].GetComponentInChildren<Toggle>().isOn = gameManager.OnRunwayCheckList[i].WasTicked;
                    break;
                case 5:
                    gameObjects[i].GetComponent<TextMeshProUGUI>().text = gameManager.AfterLandingCheckList[i].text;
                    gameObjects[i].GetComponentInChildren<Toggle>().isOn = gameManager.AfterLandingCheckList[i].WasTicked;
                    break;
                default:
                    Debug.Log("choose checklist between 1 to 5");
                    break;
            }
        }
    }

    
}

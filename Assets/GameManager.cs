using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;



    void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    public Postanalysis[] PreFlightCheckList = new Postanalysis[11];
    public Postanalysis[] EngineStartCheckList = new Postanalysis[8];
    public Postanalysis[] PreTaxiCheckList = new Postanalysis[3];
    public Postanalysis[] OnRunwayCheckList = new Postanalysis[4];
    public Postanalysis[] AfterLandingCheckList = new Postanalysis[9];

    private int preFlight = 0, EngineStart = 0, PreTaxi = 0, OnRunway = 0, AfterLanding = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PreFlightChecklist (Toggle toggle, TextMeshPro textMeshPro)
    {
        PreFlightCheckList[preFlight].set(textMeshPro.text, toggle.isOn);
        preFlight++;
    }

    public void EngineStartChecklist(Toggle toggle, TextMeshPro textMeshPro)
    {
        EngineStartCheckList[EngineStart].set(textMeshPro.text, toggle.isOn);
        EngineStart++;
    }
    public void PreTaxiChecklist(Toggle toggle, TextMeshPro textMeshPro)
    {
        PreTaxiCheckList[PreTaxi].set(textMeshPro.text, toggle.isOn);
        PreTaxi++;
    }
    public void OnRunwayChecklist(Toggle toggle, TextMeshPro textMeshPro)
    {
        OnRunwayCheckList[OnRunway].set(textMeshPro.text, toggle.isOn);
        OnRunway++;
    }
    public void AfterLandingChecklist(Toggle toggle, TextMeshPro textMeshPro)
    {
        AfterLandingCheckList[AfterLanding].set(textMeshPro.text, toggle.isOn);
        AfterLanding++;
    }

}


public class Postanalysis
{
    public bool WasTicked;
    public string text;

    public void set(string String, bool Bool)
    {
        WasTicked = Bool;
        text = String;
    }

};

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;



    void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("instance created");
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update


    public List<Postanalysis> PreFlightCheckList = new List<Postanalysis>();
    public List<Postanalysis> EngineStartCheckList = new List<Postanalysis>();
    public List<Postanalysis> PreTaxiCheckList = new List<Postanalysis>();
    public List<Postanalysis> OnRunwayCheckList = new List<Postanalysis>();
    public List<Postanalysis> AfterLandingCheckList = new List<Postanalysis>();


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PreFlightChecklist (string name)
    {
        PreFlightCheckList.Add(new Postanalysis() { text = name, WasTicked = true });
    }

    public void EngineStartChecklist(string name)
    {
        EngineStartCheckList.Add(new Postanalysis() { text = name, WasTicked = true });
    }
    public void PreTaxiChecklist(string name)
    {
        PreTaxiCheckList.Add(new Postanalysis() { text = name, WasTicked = true });
    }
    public void OnRunwayChecklist(string name)
    {
        OnRunwayCheckList.Add(new Postanalysis() { text = name, WasTicked = true });
    }
    public void AfterLandingChecklist(string name)
    {
        AfterLandingCheckList.Add(new Postanalysis() { text = name, WasTicked = true });
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

        Debug.Log(text);
    }

    public Postanalysis()
    {
        WasTicked = false;
        text = "";
    }

};

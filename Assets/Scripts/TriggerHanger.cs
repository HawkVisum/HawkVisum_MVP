using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerHanger : MonoBehaviour
{
    // Start is called before the first frame update
    float delay = 2.5f, curtime = 0f;
    [SerializeField] GameObject EndSim;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnCollision(Collider airplane)
    {
        if(airplane.gameObject.CompareTag("Airplane"))
        {
            EndSim.SetActive(true);
        }
    }

    public void clickYes()
    {
        EndSim.transform.GetChild(2).gameObject.SetActive(false);
        if (Time.time - delay > 5f)
        {
            SceneManager.LoadScene("FinalScene");
        }

    }

    public void clickNo()
    {
        EndSim.SetActive(false);
    }
}

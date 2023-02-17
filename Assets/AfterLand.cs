using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterLand : MonoBehaviour
{
    [SerializeField]
    State animator;
    [SerializeField]
    GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(animator.currentState == animator.states[2])
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}

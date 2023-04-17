using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterLand : MonoBehaviour
{
    [SerializeField]
    State animator;
    [SerializeField]
    GameObject gameobject;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if(animator.currentState == animator.states[2])
        {
            gameobject.SetActive(true);
        }
        else
        {
            gameobject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableUI : MonoBehaviour
{
    [SerializeField]
    Toggle toggle;
    [SerializeField]
    GameObject Interactabelobject;
    [SerializeField]
    GameObject gameobject;
    Vector3 initalposition;
    Quaternion initialRotation;
    
    

    void Start()
    {
        initalposition = Interactabelobject.transform.localPosition;
        initialRotation = Interactabelobject.transform.localRotation;
        toggle.interactable = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameobject.activeInHierarchy)
        {
            if (Interactabelobject.transform.localPosition != initalposition || Interactabelobject.transform.localRotation != initialRotation)
            {
                toggle.interactable = true;
            }
        }
        else
        {
            initalposition = Interactabelobject.transform.localPosition;
            initialRotation = Interactabelobject.transform.localRotation;
        }
    }



}

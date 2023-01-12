
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractOnTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isInteractable = false;

    // Update is called once per frame
    void Update()
    {
        if (isInteractable)
        {
            //personalized code can go in here when activated.
            Debug.Log("Interact");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //Compares the tag of the object entering this collider.
        if (other.tag == "Player")
        {
            //turns on interactivity 
            isInteractable = true;
        }
    }
  
   
    private void OnTriggerExit(Collider other)
    {
        //compares the tag of the object exiting this collider.
        if (other.tag == "Player")
        {
            //turns off interactivity 
            isInteractable = false;
        }
    }
}

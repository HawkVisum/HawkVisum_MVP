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

    public void YesButtonClicked()
    {
        thisTextbox.SetActive(false);
        if (nextTextbox)
            nextTextbox.SetActive(true);

    }



}

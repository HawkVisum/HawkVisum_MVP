using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterLand : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    [SerializeField]
    GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Landed"))
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}

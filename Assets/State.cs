using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    [SerializeField]
    WheelCollider[] wheels;

    bool isGrounded = true;
    bool inAir = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool[] isgrounded = new bool[3];
        bool[] inair = new bool[3];
        int i = 0;
        foreach (WheelCollider wheel in wheels)
        {
            if (wheel.isGrounded)
            {
                isgrounded[i] = true;
            }
            else
            {
                inair[i] = true;
            }
            i++;
        }
        if (isgrounded[0] && isgrounded[1] && isgrounded[2])
        {
            isGrounded = true;
            inAir = false;
        }
        else if (inair[0] && inair[1] && inair[2])
        {
            inAir = true;
            isGrounded = false;
        }
        else
        {
            inAir = false;
            isGrounded = false;
        }


        animator.SetBool("TakeOff", inAir);
        animator.SetBool("Land", isGrounded);
    }



}

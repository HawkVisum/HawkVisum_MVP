using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class State : MonoBehaviour
{
    [SerializeField]
    public string[] states;
    [SerializeField]
    WheelCollider[] wheels;

    public string currentState;


    bool isGrounded = true;
    bool inAir = false;

    // Start is called before the first frame update
    void Start()
    {
        currentState = states[0];
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
            currentState = states[2];
        }
        else if (inair[0] && inair[1] && inair[2])
        {
            inAir = true;
            isGrounded = false;
            currentState = states[1];
        }
        else
        {
            inAir = false;
            isGrounded = false;
            currentState = states[4];
        }
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision detected" + collision.gameObject.tag);
        if(collision.gameObject.tag == "airplane")
        {
            currentState = states[3];
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}

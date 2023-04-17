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
    [SerializeField]
    GameObject gameobject;

    Transform initialTransform;

    private float simTime;
    public float takeoffdistance = 0f;
    public float maxHeight;


    public bool Stopwatch = false;

    public string currentState;

    public bool takingOff = false;
    public bool landing = false;

    

    

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
        if (isgrounded[0] || isgrounded[1] || isgrounded[2])
        {
            currentState = states[2];
        }
        else if (inair[0] && inair[1] && inair[2])
        {
            currentState = states[1];
            if(takeoffdistance == 0f)
                takeoffdistance = CalDistance();
        }
        

        if (Stopwatch)
        {
            simTime += Time.deltaTime;
        }
        



    }

    private void OnCollisionEnter(Collision collision)
    {
        float forceOfImpact = collision.relativeVelocity.magnitude;
        if(forceOfImpact >= 50)
        {
            Stopwatch = false;
            currentState = states[3];
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private float CalDistance()
    {
        float distance = 0f;
        distance = Vector3.Magnitude(gameobject.transform.position - initialTransform.position);
        return distance;
    }


    public float getSimTime()
    {
        return simTime;
    }

    public void ignition()
    {
        Stopwatch = true;
    }
    public void takingoff()
    {
        initialTransform = gameobject.transform;
    }


    public void Stop()
    {
        Stopwatch = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

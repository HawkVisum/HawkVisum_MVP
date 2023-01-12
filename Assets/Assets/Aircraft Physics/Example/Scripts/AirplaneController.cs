using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using Oculus.Interaction.Input;
using UltimateXR.Avatar;

public class AirplaneController : MonoBehaviour
{
    [SerializeField]
    float rollControlSensitivity = 0.2f;
    [SerializeField]
    float pitchControlSensitivity = 0.2f;
    public float yawControlSensitivity = 0.2f;
    [SerializeField]
    float thrustControlSensitivity = 0.01f;
    [SerializeField]
    float flapControlSensitivity = 0.15f;
    [SerializeField]
    Throttle _throttle;
    [SerializeField]
    Yoke _yoke;
    [SerializeField]
    FlapHandle _flaps;

    float pitch;
    float yaw;
    float roll;
    float flap;

    float thrustPercent;
    bool brake = false;

    [SerializeField] GameObject frontWheel;
    AircraftPhysics aircraftPhysics;
    [SerializeField] Rotator propeller;
    Rigidbody rb;
    RaycastHit hit;

    private void Start()
    {
        aircraftPhysics = GetComponent<AircraftPhysics>();
        //propeller = FindObjectOfType<Rotator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
        thrustPercent = _throttle._perposition();
        propeller.speed = thrustPercent * 1500f;

        
        if ( UxrAvatar.LocalAvatarInput.GetButtonsPressDown(UltimateXR.Core.UxrHandSide.Left, UltimateXR.Devices.UxrInputButtons.Button4))
        {
            brake = !brake;
        }

        
        flap = _flaps.flapPosPer() * 45 * Mathf.Deg2Rad;

        //pitch = pitchControlSensitivity * Input.GetAxis("Vertical");
        pitch = pitchControlSensitivity * _yoke.yokeposper();
        //roll = rollControlSensitivity * Input.GetAxis("Horizontal");
        roll = rollControlSensitivity * _yoke.yokerotper();
        //yaw = yawControlSensitivity * Input.GetAxis("Yaw");
        //Debug.Log(yaw);
        Vector2 vector2 = UxrAvatar.LocalAvatarInput.GetInput2D(UltimateXR.Core.UxrHandSide.Left , UltimateXR.Devices.UxrInput2D.Joystick);

        /*if(vector2.x>0) //left
        {
            //min fric 0.02->left
            //df inc of right
            
            rightCollider.material.dynamicFriction = (vector2.x)*500f;
            leftCollider.material.dynamicFriction = 0.0f;

        }
        else if(vector2.x < 0) //right
        {
            //min fric 0.05->right
            //max = 0.2
            //df inc of left 
            rightCollider.material.dynamicFriction = 0.0f;
            leftCollider.material.dynamicFriction = -(vector2.x) * 500f;
        }
        else 
        {
            rightCollider.material.dynamicFriction = 0.05f;
            leftCollider.material.dynamicFriction = 0.05f;
            //min fric 0.02->right

        }*/
        

        //using raycast to find distance between center of wheel and groundplane
        Ray ray = new Ray(frontWheel.transform.position, -Vector3.up);
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider.tag == "ground")
            {
                if(hit.distance <= 3)
                {
                    yawControlSensitivity = 20; //subject to change
                }
            }
        }
        yaw = yawControlSensitivity * vector2.x;
    }

    private void SetThrust(float percent)
    {
        thrustPercent = Mathf.Clamp01(percent);
    }

    private void FixedUpdate()
    {
        aircraftPhysics.SetControlSurfecesAngles(pitch, roll, yaw, flap);
        //Debug.Log(thrustPercent);
        aircraftPhysics.SetThrustPercent(thrustPercent);
        aircraftPhysics.Brake(brake);
        //rb.MoveRotation(Quaternion.Euler(rb.rotation.eulerAngles + rb.transform.up * yaw));
    }
}

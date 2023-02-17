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

    [SerializeField]
    float friction = 500f;

    float pitch;
    float yaw;
    float roll;
    float flap;

    float thrustPercent;
    bool brake = false;

    AircraftPhysics aircraftPhysics;
    [SerializeField] Rotator propeller;

    [SerializeField]
    WheelCollider[] wheels;

    [SerializeField] float wheelTurn = 30f;

    private void Start()
    {
        aircraftPhysics = GetComponent<AircraftPhysics>();
    }

    private void Update()
    {
        
        thrustPercent = _throttle._perposition();
        propeller.speed = thrustPercent * 2700f;


        if (UxrAvatar.LocalAvatarInput.GetButtonsPress(UltimateXR.Core.UxrHandSide.Left, UltimateXR.Devices.UxrInputButtons.Button4))
        {
            brake = true;
        }
        else
            brake = false;

        
        flap = _flaps.flapPosPer() * 45 * Mathf.Deg2Rad;
        pitch = pitchControlSensitivity * _yoke.yokeposper();
        roll = rollControlSensitivity * _yoke.yokerotper();
        Vector2 vector2 = UxrAvatar.LocalAvatarInput.GetInput2D(UltimateXR.Core.UxrHandSide.Left , UltimateXR.Devices.UxrInput2D.Joystick);
        yaw = vector2.x * yawControlSensitivity;

        if (thrustPercent > 0)
        {
            foreach (WheelCollider wheel in wheels)
            {
                wheel.motorTorque = 0.0001f;
            }
        }
        wheels[0].steerAngle = vector2.x * wheelTurn;

        
    }


    private void FixedUpdate()
    {
        aircraftPhysics.SetControlSurfecesAngles(pitch, roll, yaw, flap);
        //Debug.Log(thrustPercent);
        aircraftPhysics.SetThrustPercent(thrustPercent);
        Brake(brake);


    }


    public void Brake(bool isBraking) //increases drag on wheels
    {
        if (isBraking)
        {
            foreach (WheelCollider wheel in wheels)
            {
                wheel.brakeTorque = friction;
            }
        }
    }
}

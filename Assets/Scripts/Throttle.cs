using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltimateXR.Manipulation;
using UltimateXR.Avatar;

public class Throttle : MonoBehaviour
{
    [SerializeField] GameObject pos;
    [SerializeField] GameObject initialtransform;
    [SerializeField] GameObject finaltransform;
    [SerializeField]
    UxrGrabbableObject grabbableObject;
    [SerializeField]
    float speed = 0.001f; // 1mm
    float LowSpeed;
    float HighSpeed = 0.01f; //1cm


    // Start is called before the first frame update
    void Start()
    {
        LowSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (UxrGrabManager.Instance.IsBeingGrabbed(grabbableObject))
        {
            float dis = speed * Time.deltaTime * UxrAvatar.LocalAvatarInput.GetInput2D(UltimateXR.Core.UxrHandSide.Right, UltimateXR.Devices.UxrInput2D.Joystick).y;//*the grabbing hand joystick vertical value ;
            transform.Translate(0, 0, -dis);
        }
        if (UxrAvatar.LocalAvatarInput.GetButtonsPress(UltimateXR.Core.UxrHandSide.Right,UltimateXR.Devices.UxrInputButtons.Joystick))
        {
            speed = HighSpeed;
    }
        else{
            speed=LowSpeed;
        }
    }

    public float _perposition()
    {
        return (Mathf.InverseLerp(initialtransform.transform.localPosition.z, finaltransform.transform.localPosition.z, pos.transform.localPosition.z));
    }
}

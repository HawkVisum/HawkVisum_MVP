using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class VerticalSpeedIndicator : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    float mpsto100fpm = 1.9685f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = rb.velocity.y * mpsto100fpm;
        speed *= 0.05f;
        speed *= 172;
        transform.localEulerAngles = new Vector3(0, 0, speed);
        
    }
}

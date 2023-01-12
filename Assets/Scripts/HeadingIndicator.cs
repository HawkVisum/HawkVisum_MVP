using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadingIndicator : MonoBehaviour
{
    [SerializeField] GameObject aircraft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rot = -aircraft.transform.localRotation.eulerAngles.y;
        transform.localRotation = Quaternion.Euler(0, 0, rot);
    }
}

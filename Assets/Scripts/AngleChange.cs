using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleChange : MonoBehaviour
{
    [SerializeField]Yoke yoke;
    float MaxAngle = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(1, 0, 0) * MaxAngle * yoke.yokeposper());
        Debug.Log(transform.localRotation.eulerAngles.x);
    }
}

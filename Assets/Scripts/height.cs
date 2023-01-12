using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class height : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxheight = 3010.0f;
    float height_cur;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        height_cur = transform.position.y * 3.28084f;
        maxheight = Mathf.Max(maxheight, height_cur);
    }
    public float getheight()
    {
        return maxheight;
    }
}

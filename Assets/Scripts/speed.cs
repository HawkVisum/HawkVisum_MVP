using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxspeed = 0.0f;
    void Start()
    {
        StartCoroutine(calspeed());
    }


    IEnumerator calspeed()
    {
        bool isplaying = true;
        while(isplaying)
        {
            Vector3 prevpos = transform.position;
            yield return new WaitForFixedUpdate();
            float speed = Mathf.RoundToInt(Vector3.Distance(transform.position, prevpos)/Time.fixedDeltaTime);
            speed *= 1.94384f;
            maxspeed = Mathf.Max(maxspeed, speed);
        }
    }

    public float getspeed()
    {
        return maxspeed;
    }

}

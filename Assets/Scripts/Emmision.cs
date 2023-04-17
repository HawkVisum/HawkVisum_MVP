using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emmision : MonoBehaviour
{
    Renderer _renderer;
    Material material;
    bool blinkon = false;
    bool on = false;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (blinkon)
        {
            float emmision = Mathf.PingPong(Time.time, 20);
            _renderer.material.SetColor("_EmmisionColor", new Color(1f, 1f, 1f) * emmision);
        }
        else if (on)
        {
            _renderer.material.SetColor("_EmmisionColor", new Color(1f, 1f, 1f) * 20);
        }
        else
        {
            _renderer.material.SetColor("_EmmisionColor", new Color(1f, 1f, 1f) * 0);
        }
        
    }

    public void matEmissionBlink()
    {
        blinkon = !blinkon;
    }

    public void matOn()
    {
        on = !on;
    }

}

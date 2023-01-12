using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftCalculation : MonoBehaviour
{

    public AnimationCurve Cl = new AnimationCurve();
    
    [SerializeField]
    Rigidbody rb;
    float density = 1.225f;

    // Start is called before the first frame update
    void Start()
    {
        Cl.AddKey(-9.25f, -0.4676f);
        Cl.AddKey(-9.0f, -0.649f);
        Cl.AddKey(-8.75f, -0.6415f);
        Cl.AddKey(-8.5f, -0.649f);
        Cl.AddKey(-8.25f, -0.6597f);
        Cl.AddKey(-8.0f, -0.6647f);
        Cl.AddKey(-7.75f, -0.664f);
        Cl.AddKey(-7.5f, -0.6588f);
        Cl.AddKey(-7.25f, -0.6495f);
        Cl.AddKey(-7.0f, -0.637f);
        Cl.AddKey(-6.75f, -0.6223f);
        Cl.AddKey(-6.5f, -0.6052f);
        Cl.AddKey(-6.25f, -0.5859f);
        Cl.AddKey(-6.0f, -0.5659f);
        Cl.AddKey(-5.75f, -0.5454f);
        Cl.AddKey(-5.5f, -0.524f);
        Cl.AddKey(-5.25f, -0.5023f);
        Cl.AddKey(-5.0f, -0.4796f);
        Cl.AddKey(-4.75f, -0.4571f);
        Cl.AddKey(-4.5f, -0.4346f);
        Cl.AddKey(-4.25f, -0.4122f);
        Cl.AddKey(-4.0f, -0.3902f);
        Cl.AddKey(-3.75f, -0.368f);
        Cl.AddKey(-3.5f, -0.3461f);
        Cl.AddKey(-3.25f, -0.324f);
        Cl.AddKey(-3.0f, -0.3019f);
        Cl.AddKey(-2.75f, -0.2753f);
        Cl.AddKey(-2.5f, -0.2306f);
        Cl.AddKey(-2.25f, -0.1869f);
        Cl.AddKey(-2.0f, -0.1494f);
        Cl.AddKey(-1.75f, -0.1161f);
        Cl.AddKey(-1.5f, -0.0695f);
        Cl.AddKey(-1.25f, 0.0156f);
        Cl.AddKey(-1.0f, 0.0782f);
        Cl.AddKey(-0.75f, 0.1209f);
        Cl.AddKey(-0.5f, 0.1665f);
        Cl.AddKey(-0.25f, 0.2237f);
        Cl.AddKey(0.0f, 0.2623f);
        Cl.AddKey(0.25f, 0.3002f);
        Cl.AddKey(0.5f, 0.337f);
        Cl.AddKey(0.75f, 0.3725f);
        Cl.AddKey(1.0f, 0.4063f);
        Cl.AddKey(1.25f, 0.4371f);
        Cl.AddKey(1.5f, 0.4637f);
        Cl.AddKey(1.75f, 0.4896f);
        Cl.AddKey(2.0f, 0.515f);
        Cl.AddKey(2.25f, 0.5396f);
        Cl.AddKey(2.5f, 0.5637f);
        Cl.AddKey(2.75f, 0.5877f);
        Cl.AddKey(3.0f, 0.6117f);
        Cl.AddKey(3.25f, 0.6359f);
        Cl.AddKey(3.5f, 0.6601f);
        Cl.AddKey(3.75f, 0.6843f);
        Cl.AddKey(4.0f, 0.7087f);
        Cl.AddKey(4.25f, 0.7331f);
        Cl.AddKey(4.5f, 0.7575f);
        Cl.AddKey(4.75f, 0.7821f);
        Cl.AddKey(5.0f, 0.8043f);
        Cl.AddKey(5.25f, 0.8272f);
        Cl.AddKey(5.5f, 0.8503f);
        Cl.AddKey(5.75f, 0.8718f);
        Cl.AddKey(6.0f, 0.8941f);
        Cl.AddKey(6.25f, 0.914f);
        Cl.AddKey(6.5f, 0.9336f);
        Cl.AddKey(6.75f, 0.9522f);
        Cl.AddKey(7.0f, 0.9695f);
        Cl.AddKey(7.25f, 0.9849f);
        Cl.AddKey(7.5f, 0.9979f);
        Cl.AddKey(7.75f, 1.0091f);
        Cl.AddKey(8.0f, 1.0201f);
        Cl.AddKey(8.25f, 1.0338f);
        Cl.AddKey(8.5f, 1.0496f);
        Cl.AddKey(8.75f, 1.0677f);
        Cl.AddKey(9.0f, 1.0874f);
        Cl.AddKey(9.25f, 1.1079f);
        Cl.AddKey(9.5f, 1.1314f);
        Cl.AddKey(9.75f, 1.1526f);
        Cl.AddKey(10.0f, 1.1784f);
        Cl.AddKey(10.25f, 1.1961f);
        Cl.AddKey(10.5f, 1.214f);
        Cl.AddKey(10.75f, 1.2391f);
        Cl.AddKey(11.0f, 1.2486f);
        Cl.AddKey(11.25f, 1.2553f);
        Cl.AddKey(11.5f, 1.2639f);
        Cl.AddKey(11.75f, 1.2761f);
        Cl.AddKey(12.0f, 1.2907f);
        Cl.AddKey(12.25f, 1.2781f);
        Cl.AddKey(12.5f, 1.261f);
        Cl.AddKey(12.75f, 1.2411f);
        Cl.AddKey(13.0f, 1.2187f);
        Cl.AddKey(13.25f, 1.1933f);
        Cl.AddKey(13.5f, 1.165f);
        Cl.AddKey(13.75f, 1.1339f);
        Cl.AddKey(14.0f, 1.1009f);
        Cl.AddKey(14.25f, 1.0677f);
        Cl.AddKey(14.5f, 1.0377f);
        Cl.AddKey(14.75f, 1.0077f);
        Cl.AddKey(15.0f, 0.9777f);
        Cl.AddKey(15.25f, 0.9477f);
        Cl.AddKey(15.5f, 0.9177f);
        Cl.AddKey(15.75f, 0.8877f);
        Cl.AddKey(16.0f, 0.8577f);
        Cl.AddKey(16.25f, 0.8277f);
        Cl.AddKey(16.5f, 0.7977f);
        Cl.AddKey(16.75f, 0.7677f);
        Cl.AddKey(17.0f, 0.7377f);
        Cl.AddKey(17.25f, 0.7077f);
        Cl.AddKey(17.5f, 0.6777f);
        Cl.AddKey(17.75f, 0.6477f);
        Cl.AddKey(18.0f, 0.6177f);
        Cl.AddKey(18.25f, 0.5877f);
        Cl.AddKey(18.5f, 0.5577f);
        Cl.AddKey(18.75f, 0.5277f);
        Cl.AddKey(19.0f, 0.4977f);
        Cl.AddKey(19.25f, 0.4677f);
        Cl.AddKey(19.5f, 0.4377f);
        Cl.AddKey(19.75f, 0.4077f);
        Cl.AddKey(20.0f, 0.3777f);
        Cl.preWrapMode = WrapMode.ClampForever;
        Cl.postWrapMode = WrapMode.ClampForever;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Vector3 liftForce(float area,float angleOfAttack)
    {
        
        float cl = Cl.Evaluate(angleOfAttack);
        float velocity = (rb.velocity.magnitude);
        Vector3 liftforce = Vector3.up*(cl*0.5f*Mathf.Pow(velocity,2)*density*area);
        return liftforce;
    }
}

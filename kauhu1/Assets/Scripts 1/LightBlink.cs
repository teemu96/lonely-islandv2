using UnityEngine;
using System.Collections;

public class LightBlink : MonoBehaviour {


    public Light FirePlace;
    public float lightIntensity = 5.0f;
    public float fadeRate = 2.0f;
    
	
	void Start ()
    {
        Update();
    }

    void Update()
    {
        float phi = Time.time / fadeRate * 2 * Mathf.PI;
        float amplitude = Mathf.Cos(phi) * 0.5f + 0.5f;
        FirePlace.intensity = amplitude;
    }

}

using UnityEngine;

public class NoiseFilter 
{
    Noise noise = new Noise();
    public float Evaluate(Vector3 point)
    {
        float noiseValue = (noise.Evaluate(point)+1) * .5f;
        return noiseValue;
    }
    
}

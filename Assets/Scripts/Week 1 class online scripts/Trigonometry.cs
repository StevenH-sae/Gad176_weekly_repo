using System;
using UnityEngine;

public class Trigonometry : MonoBehaviour
{
    public float amplitude = 1f;
    public float frequency = 1f;
    public float ratationalSpeed = 2f;

    public int resolution = 100; // number of points to show

    // Update is called once per frame
    void Update()
    {
        //MoveWithSin();
        //MoveWithCosine();
        MoveWithTan();
    }

    void MoveWithSin()
    {
        // oscilating vertial motion 
        // here we take the current position and add the amplitude to it, and multiply it by the current time and frequency it should occur
        float yPosition = (transform.position.y + amplitude) * Mathf.Sin(Time.time * frequency);
        
        // here I am playing around with the sin math.f like a wave following the sin math (I think)
        
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
    }

    void MoveWithCosine()
    {
        // this will also move my cube but it will move from left to right
        float xPosition = (transform.position.x + amplitude) * Mathf.Sin(Time.time * frequency);
        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
    }

    void MoveWithTan()
    {
        float rotationAngle = Mathf.Tan(Time.time * ratationalSpeed);
        transform.rotation = Quaternion.Euler(0f, 0f, rotationAngle);
    }

    private void OnDrawGizmos()
    {
        DrawCosineWave();
        DrawSinWave();
        DrawTanWave();
        Gizmos.color = Color.red;
    }

    void DrawSinWave()
    {
        Gizmos.color = Color.red;
        for (int i = 0; i < resolution; i++)
        {
            float x = i / (float)resolution * 4 * Mathf.PI; // use of number 4 to see lines easier
            float y = amplitude * Mathf.Sin(frequency * x);
            
            Vector3 point = new Vector3(x, y, 0);
            Gizmos.DrawSphere(point, 0.05f);
        }
    }

    void DrawCosineWave()
    {
        Gizmos.color = Color.blue;
        for (int i = 0; i < resolution; i++)
        {
            float x = i / (float)resolution * 4 * Mathf.PI; // use of number 4 to see lines easier
            float y = amplitude * Mathf.Cos(frequency * x);
            
            Vector3 point = new Vector3(x, y, 1f);
            Gizmos.DrawSphere(point, 0.05f);
        }
    }

    void DrawTanWave()
    {
        Gizmos.color = Color.green;
        for (int i = 0; i < resolution; i++)
        {
            float x = i / (float)resolution * 4 * Mathf.PI; // use of number 4 to see lines easier
            float y = amplitude * Mathf.Tan(frequency * x);
            
            //clamping numbers so they can't go out of range of the numbers
            y = Mathf.Clamp(y, -10f, 10f);
            
            Vector3 point = new Vector3(x, y, 2f);
            Gizmos.DrawSphere(point, 0.05f);
        }
    }
    //useful for making animation of head bobs!
    //spawn in object with Style!
    //make object swing instead of animation it, use code!
}

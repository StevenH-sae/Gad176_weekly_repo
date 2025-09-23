using System;
using UnityEngine;

public class DebugDrawing : MonoBehaviour
{
    public Transform target;

    public float radius = 20;
    public float startAngle = 30f;
    public float endAngle = 125f;
    public int resolution = 100; // how many lines to draw for the arc

    // Update is called once per frame
    void Update()
    {
        //DebugLine();
        //DebugRay();
    }

    void DebugLine()
    {
        if (!target)
        {
            return;
        }
        Debug.DrawLine(transform.position, target.position, Color.cyan, 5f);
    }
    
    void DebugRay()
    {
        if (!target)
        {
            return;
        }
        
        Vector3 direction = transform.position - target.position;
        
        Debug.DrawRay(target.position, direction, Color.red);
        
        Debug.DrawRay(target.position, transform.forward, Color.green);
        Debug.DrawRay(target.position, transform.up, Color.blue);
        Debug.DrawRay(target.position, transform.right, Color.black);
    }

    private void OnDrawGizmos()
    {
        DrawArc();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawCube(transform.position, new Vector3(1f, 1f, 1f));
        
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(1.5f, 1.5f, 1.5f));
        
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(Vector3.left, 1f);
    }

    void DrawArc()
    {
        Gizmos.color = Color.green;
        
        float angleIncrement = (endAngle - startAngle) / resolution; // tells how far apart each line should be
        float currentAngle = startAngle; //start drawing here

        for (int i = 0; i < resolution; i++)
        {
            //grabs the x and y coordinates for the line
            float x = radius * Mathf.Cos(currentAngle * Mathf.Deg2Rad);
            float y = radius * Mathf.Sin(currentAngle * Mathf.Deg2Rad);
            
            Vector3 point = transform.position + new Vector3(x, y, 0);
            Gizmos.DrawLine(point, transform.position);
            
            
            currentAngle += angleIncrement;
        }
        
    }
}

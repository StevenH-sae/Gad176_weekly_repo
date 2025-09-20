using UnityEngine;

public class Angles : MonoBehaviour
{
    public Transform targetObject; // my target in the world, to be used for angle detection
    public float rotateSpeed = 25f; // how fast we should be rotating
    // Update is called once per frame
    void Update()
    {
        //CheckAngle();
        RotationExample();
    }

    void RotationExample()
    {
        // grabs input from unity being between -1 and 1
        float rotationalInput = Input.GetAxis("Horizontal");
        
        // calculate the rotation in redians using MathF.Deg2Rad
        float rotationInRadiens = rotationalInput * Mathf.Deg2Rad;
        
        //apply this rotation
        transform.Rotate(Vector3.up, rotationInRadiens * rotateSpeed);
    }

    void CheckAngle()
    {
        if (targetObject == null)
        {
            return;
        }
        // this is want I want to get the direction from the object to my target
        Vector3 directionToTarget = targetObject.position - transform.position;
        
        // calculate the angle between my forwad direction to my target
        float angle = Vector3.Angle(transform.forward, directionToTarget);
        
        Debug.Log("The angle is " + angle);
        if (angle < 10)
        {
            // player can see enemy
        }
        
        // in this case returning a signed angle, positive or negative based on the axies we are checking against, this one is checking the y axis
        float signedAngle = Vector3.SignedAngle(transform.forward, directionToTarget, Vector3.up);
        Debug.Log("The signed angle is " + signedAngle);

        if (signedAngle > -10 && signedAngle < 10)
        {
            if (Vector3.Distance(transform.position, targetObject.position) < 10)
            {
                Debug.Log("we are in the players 20 degree cone");
            }
            
        }
    }
}

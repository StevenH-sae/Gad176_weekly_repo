using UnityEngine;

public class VectorMath : MonoBehaviour
{
    public Transform otherObject;

    public float flowSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // addition of Vectors
        // Subtraction of Vectors
        // Dot Product
        // Normalisation
        // Magnitude
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            AddVectors();
        }

        if (Input.GetKey(KeyCode.E))
        {
            SubVectors();
        }
        //YellIfClose();
        FacingDirection();
    }

    void AddVectors()
    {
        // addition of Vectors
        // when we take two vectors and add them we get a new position
        transform.position += new Vector3(0, 0, -1);
    }

    void SubVectors()
    {
        
        if (otherObject == null)
        {
            return;
        }
        // Subtracting of Vectors
        // when taking from two vectors we get is the direction to and from
        Vector3 direction = (otherObject.position - transform.position);
        Debug.Log("Length is " + direction.magnitude);  // shows the length of this Vector
        
        direction = direction.normalized; // normalised vector is scaling this down between 0 and 1
        Debug.Log("Normalised Length is " + direction.magnitude); 
        

        
        // Normalised makes it a ratio between 0 and 1 (e.g. 3/4 = 0.75) or rather 75%
        transform.position += direction * flowSpeed * Time.deltaTime;
    }

    void YellIfClose()
    {
        Debug.Log(Vector3.Distance(transform.position, otherObject.position)); 
        // the distance function is the distance between two points

        if (Vector3.Distance(transform.position, otherObject.position) < 1f)
        {
            Debug.Log("I'm close");
        }
        
    }

    void FacingDirection()
    {
        // this will give me one of 3 numbers
        // 0 = right angles to each other
        // 1 = facing the same direction
        // -1 = facing opposite direction
        Debug.Log(Vector3.Dot(transform.forward, otherObject.forward));

        if (Vector3.Dot(transform.forward, otherObject.forward) > 0 && Vector3.Dot(transform.forward, otherObject.forward) <= 1)
        {
            //we are facing the same way
        }
        else if (Vector3.Dot(transform.forward, otherObject.forward) < 0 && Vector3.Dot(transform.forward, otherObject.forward) <= -1)
        {
            // we are facing opposite
        }
        else
        {
            // we are at right angles to each other
        }
    }
}

using UnityEngine;

public class CannonControl : MonoBehaviour
{
    public Transform cannonTransform;
    public Transform cannonFirePoint;
    public GameObject cannonBallPrefab;
    public float projectileSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        RotateCannonWithMouse();
    }

    void RotateCannonWithMouse()
    {
        // grabs the current mouse position on SCREEN
        Vector3 mousePosition = Input.mousePosition;
        
        // Convert the mouse position to a point in world space
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, Camera.main.nearClipPlane));
        
        //calculate the direction from the cannon to mouse position
        Vector3 directionsToMouse = worldMousePosition - cannonTransform.position;
        
        //calculate the launch angle in radians
        float launchAngleInRadians = Mathf.Atan2(directionsToMouse.y, directionsToMouse.x);
        
        //converting my radians to degrees
        float launchAngleInDegrees = launchAngleInRadians * Mathf.Rad2Deg;
        
        //rotate the cannon to face the mouse cursor
        cannonTransform.rotation = Quaternion.Euler(0, 0, launchAngleInDegrees);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    public void Fire()
    {
        GameObject clone = Instantiate(cannonBallPrefab, cannonFirePoint.position, Quaternion.identity);

        clone.GetComponent<Rigidbody>().linearVelocity = cannonFirePoint.forward * projectileSpeed;
    }
}

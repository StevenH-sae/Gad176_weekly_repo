using UnityEngine;

public class Drone : MonoBehaviour, IUsable
{
    public void Activate()
    {
        Debug.Log("Drone Active");
    }


    public void Use()
    {
        Activate();
    }

}

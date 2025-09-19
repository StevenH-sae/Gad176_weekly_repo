using UnityEngine;

public class Shield : MonoBehaviour, IUsable
{
    public void PullPin()
    {
        Debug.Log("Activated Shield");
    }


    public void Use()
    {
        PullPin();
    }

}

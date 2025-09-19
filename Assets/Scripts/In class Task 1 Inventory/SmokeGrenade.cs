using UnityEngine;

public class SmokeGrenade : MonoBehaviour, IUsable
{
    private void PullPin()
    {
        Debug.Log("Pull Pin");
    }


    public void Use()
    {
        PullPin();
    }

}

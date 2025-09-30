using UnityEngine;

namespace SAE.GAD176.Tutorials.Inheritance
{
    public class SmartEnemy : FastEnemy
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            playerReference = FindObjectOfType<Player>();
        }

        // Update is called once per frame
        void Update()
        {
            // RunAtPlayer function is getting from FastEnemy class which is also Inheritance from enemy class
            RunAtPlayer();
            HitPlayer();
        }

        protected void HitPlayer()
        {
            if (playerReference)
            {
                if (Vector3.Distance(transform.position, playerReference.transform.position) < 1)
                {
                    Debug.Log("Hit the Player! Arrrgh you Basterd!");
                }
            }
        }
    }
}

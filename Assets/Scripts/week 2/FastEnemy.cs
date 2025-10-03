using UnityEngine;

namespace SAE.GAD176.Tutorials.Inheritance
{
    public class FastEnemy : Enemy
    {
        void Start()
        {
            playerReference = FindObjectOfType<Player>();
        }

        void Update()
        {
            // shout function is getting inheritance from 'enemy' class
            Shout();
            RunAtPlayer();
        }

        protected void RunAtPlayer()
        {
            if (playerReference)
            {
                if (Vector3.Distance(transform.position, playerReference.transform.position) < 10)
                {
                    Debug.Log("Run straight to the player");
                }
            }
        }
    }
}

using UnityEngine;

namespace SAE.GAD176.Tutorials.Inheritance
{
    public class FastEnemy : Enemy
    {
        protected override void Start()
        {
            base.Start();
            RunAtPlayer();
        }
        protected override void Shout()
        {
            
            // extra functionality
            if (playerReference != null)
            {
                if (Vector3.Distance(playerReference.transform.position, transform.position) < 10)
                {
                    Debug.Log("REEEEEEEEEEEEEEEEEE " + transform.name);
                }
            }
            
        }

        protected override void Update()
        {
            // shout function is getting inheritance from 'enemy' class
            
            //RunAtPlayer();
        }

        protected void RunAtPlayer()
        {
            if (playerReference)
            {
                if (Vector3.Distance(transform.position, playerReference.transform.position) < 10)
                {
                    Debug.Log("Run straight to the player " + transform.name);
                }
            }
        }
        
        public override void ChangeHealth(float amount)
        {
            base.ChangeHealth(amount);
            Debug.Log("Run away! " + transform.name);
        }
    }
}

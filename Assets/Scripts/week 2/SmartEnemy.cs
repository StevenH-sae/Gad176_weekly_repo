using UnityEngine;

namespace SAE.GAD176.Tutorials.Inheritance
{
    public class SmartEnemy : FastEnemy
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
       protected override void Start()
        {
            base.Start();
            HitPlayer();
            
        }

        // Update is called once per frame
        protected override void Update()
        {
            // RunAtPlayer function is getting from FastEnemy class which is also Inheritance from enemy class
            
        }

        protected void HitPlayer()
        {
            if (playerReference)
            {
                if (Vector3.Distance(transform.position, playerReference.transform.position) < 10)
                {
                    Debug.Log("Hit the Player! Arrrgh you Basterd! " + transform.name);
                }
            }
        }
        protected override void Shout()
        {
            
            // extra functionality
            if (playerReference != null)
            {
                if (Vector3.Distance(playerReference.transform.position, transform.position) < 10)
                {
                    Debug.Log("Stop right there " + transform.name);
                }
            }
        }

        public override void ChangeHealth(float amount)
        {
            base.ChangeHealth(amount);
            Debug.Log("Uh Oh " + transform.name);
        }
    }
}

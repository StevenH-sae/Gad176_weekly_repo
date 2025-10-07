using UnityEngine;

namespace SAE.GAD176.Tutorials.Inheritance
{
    public class Enemy : MonoBehaviour
    {
        protected Player playerReference;
        [SerializeField] private float playerHealth = 100f;
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        protected virtual void Start()
        {
            playerReference = FindObjectOfType<Player>();
            Shout();
        }

        // Update is called once per frame
        protected virtual void Update()
        {
            
        }
        protected virtual void Shout()
        {
            if (playerReference)
            {
                if (Vector3.Distance(transform.position, playerReference.transform.position) < 5)
                {
                    Debug.Log("Too close! " + transform.name);
                }
            }
        }

        public virtual void ChangeHealth(float amount)
        {
            playerHealth += amount;
        }
    }
}

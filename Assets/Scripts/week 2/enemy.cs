using UnityEngine;

namespace SAE.GAD176.Tutorials.Inheritance
{
    public class Enemy : MonoBehaviour
    {
        protected Player playerReference;
        [SerializeField] private float playerHealth = 100f;
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            playerReference = FindObjectOfType<Player>();
        }

        // Update is called once per frame
        void Update()
        {
            Shout();
        }
        protected void Shout()
        {
            if (playerReference)
            {
                if (Vector3.Distance(transform.position, playerReference.transform.position) < 5)
                {
                    Debug.Log("Too close!" + transform.name);
                }
            }
        }

        public void ChangeHealth(float amount)
        {
            playerHealth += amount;
        }
    }
}

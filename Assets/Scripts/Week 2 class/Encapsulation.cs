using UnityEngine;

namespace StevenScripts
//namespace examples to use
//company.project.system.subsystem
//SAE.GAD176.Characters.Health
{


    /// <summary>
    /// Good practice to put a summary at the top of any class to tell what this class does
    /// This class handles the Player Health
    /// </summary>
    public class Encapsulation : MonoBehaviour
    {
        // private variable only accessible in this class

        // SerializedField lets developers access this variable in Unity but outside class can't
        [SerializeField] private float playerHealth;

        // example of a public function that can be access OUTSIDE of this class with a variable input 'health' to be used
        public void ChangeHealth(float health)
        {
            playerHealth += health;

            // example can check the amount of health coming in or going out
            // perhaps play a sound when health goes down and or goes up
            GetHealth();
        }

        #region Unity Specific Region

        public float GetHealth()
        {
            return playerHealth;
        }

        #endregion

        #region Custom Private Functions
        

        #endregion
    }
}

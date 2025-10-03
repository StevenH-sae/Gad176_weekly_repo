using System.Collections.Generic;
using UnityEngine;

namespace SAE.GAD176.Tutorials.Inheritance
{
    public class Player : MonoBehaviour
    {
        public List<Enemy> allEnemiesInScene = new List<Enemy>();
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            allEnemiesInScene.AddRange(FindObjectsOfType<Enemy>());
            for (int i = 0; i < allEnemiesInScene.Count; i++)
            {
                allEnemiesInScene[i].ChangeHealth(-20);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

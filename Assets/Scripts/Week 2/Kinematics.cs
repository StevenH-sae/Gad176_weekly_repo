using UnityEngine;

namespace SAE.GAD176.Tutorials.Kinematics
{
    public class Kinematics : MonoBehaviour
    {

        [SerializeField] private Transform targetPosition;

        [SerializeField] private float moveSpeed = 0.7f;
        
        private Vector3 referenceVelocity = Vector3.zero;

        [SerializeField] private float smoothness = 1f;

        [SerializeField] private Vector3 targetRotation;
        [SerializeField] private Vector3 targetScale = Vector3.one;

        [SerializeField] private float scaleSpeed = 1f;

        [SerializeField] private Vector3 referenceScaleVelocity = Vector3.zero;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Move();
            Rotate();
            Scale();
        }

        private void Move()
        {
            // Lerp = Linear interpolation
            // transform.position = Vector3.Lerp(transform.position, targetPosition.position, moveSpeed * Time.deltaTime);
            
            // smooth damp = effective gradually moving to a point using velocity
            // transform.position = Vector3.SmoothDamp(transform.position, targetPosition.position, ref  referenceVelocity, moveSpeed);
            
            // move towards = effectively it moves straight towards a fixed place
            // transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, moveSpeed * Time.deltaTime);
        }

        private void Rotate()
        {
            // Lerp
            // transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(targetRotation), smoothness * Time.deltaTime);
            
            // slerp = spherical linear interpolation
            // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(targetRotation), smoothness * Time.deltaTime);
            
            // rotate towards
            // transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(targetRotation), smoothness * Time.deltaTime);
        }

        private void Scale()
        {
            // Lerp
            // transform.localScale = Vector3.Lerp(transform.localScale, targetScale, scaleSpeed * Time.deltaTime);
            
            // Smooth damp
            // transform.localScale = Vector3.SmoothDamp(transform.localScale, targetScale, ref referenceScaleVelocity, scaleSpeed);
            
            // Scale
            // transform.localScale = Vector3.Scale(transform.localScale, Vector3.one + (targetScale - transform.localScale) * scaleSpeed * Time.deltaTime);
            
        }
    }
}

using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 1f;

    private void Update()
    {
        // Rotate the camera smoothly, based on the rotationDegrees
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, GravityController.globalGravityAngle), rotationSpeed * Time.deltaTime);
    }
}

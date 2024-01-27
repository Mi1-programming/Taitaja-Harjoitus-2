using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 15f;

    private void Update()
    {
        // Rotate the camera smoothly, based on the rotationDegrees
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, GravityController.globalGravityAngle), rotationSpeed * Time.deltaTime);
    }
}

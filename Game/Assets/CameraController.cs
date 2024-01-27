using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float camRotationSpeed = 15f;
    [SerializeField] private float rotationAngle;

    [SerializeField] private UnityEvent<int> OnGravityChange;


    private void Update()
    {
        // Change the gravity when "a" or "d" is down
        if (Input.GetKeyDown(KeyCode.A)) ChangeGravity(-90);
        if (Input.GetKeyDown(KeyCode.D)) ChangeGravity(90);

        // Rotate the camera smoothly, based on the rotationDegrees
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, rotationAngle), camRotationSpeed * Time.deltaTime);
    }

    private void ChangeGravity(float addedAngle)
    {
        rotationAngle = (rotationAngle + addedAngle) % 360;
        OnGravityChange.Invoke(Mathf.RoundToInt(rotationAngle));
    }
}

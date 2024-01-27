using UnityEngine;
using System.Collections.Generic;

public class Gravity : MonoBehaviour
{
    public static List<Gravity> gravities = new List<Gravity>();
    public int angle = 0;
    public float force = 10.0f;
    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        gravities.Add(this);
    }
    private void OnDisable()
    {
        gravities.Remove(this);
    }
    private void FixedUpdate()
    {
        rb2d.AddForce(Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.down * force);
    }
}

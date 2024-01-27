using UnityEngine;

public class GravityInterface : MonoBehaviour
{
    [SerializeField] private Gravity[] gravities;

    public void RotateLocalGravity(int addedAngle)
    {
        foreach (var gravity in gravities)
        {
            gravity.angle += addedAngle;
        }
    }
}

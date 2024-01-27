using UnityEngine;

public class GravityController : MonoBehaviour
{
    public static GravityController self;
    public static float globalGravityAngle = 0;

    private void Start()
    {
        self = this;
    }
    private void Awake()
    {
        globalGravityAngle = 0;
    }
    public void Turn(int addedAngle)
    {
        if (LevelDataLoader.self.MovesLeft == 0) return;
        LevelDataLoader.self.MovesLeft--;
        RotateGlobalGravity(addedAngle);
    }
    public void RotateGlobalGravity(int addedAngle)
    {
        globalGravityAngle += addedAngle;
    }
}

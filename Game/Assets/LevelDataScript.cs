using UnityEngine;

public class LevelDataScript : MonoBehaviour
{
    public static LevelDataScript self;
    public int moveLimit = 10;

    private void Start()
    {
        self = this;
    }
}

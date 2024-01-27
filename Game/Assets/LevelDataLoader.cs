using UnityEngine;
using UnityEngine.Events;

public class LevelDataLoader : MonoBehaviour
{
    public static LevelDataLoader self;
    public int movesLeft = 0;
    public UnityEvent<string> onMove;
    public int MovesLeft
    {
        get {
            return movesLeft;
        }
        set {
            movesLeft = value;
            onMove.Invoke(movesLeft.ToString());
        }
    }

    private void Start()
    {
        self = this;
        MovesLeft = LevelDataScript.self.moveLimit;
    }
}

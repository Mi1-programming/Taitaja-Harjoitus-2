using UnityEngine;
using UnityEngine.SceneManagement;

public class AddScene : MonoBehaviour
{
    [SerializeField] private int sceneIndex;

    private void Start()
    {
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
    }
}

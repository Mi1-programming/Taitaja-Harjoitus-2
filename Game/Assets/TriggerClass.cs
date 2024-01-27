using UnityEngine;
using UnityEngine.Events;

public class TriggerClass : MonoBehaviour
{
    [SerializeField] private UnityEvent onEnter;
    [SerializeField] private UnityEvent onExit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        onEnter.Invoke();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        onExit.Invoke();
    }
}

using UnityEngine;
using UnityEngine.Events;

public class Control : MonoBehaviour
{
    [SerializeField] private string input;
    [SerializeField] private UnityEvent<float> onAxis;
    [SerializeField] private UnityEvent onButton;
    [SerializeField] private UnityEvent onButtonDown;
    [SerializeField] private UnityEvent onButtonUp;
    
    private void Update()
    {
        float axis = Input.GetAxis(input);
        onAxis.Invoke(axis);

        if (Input.GetButton(input)) { onButton.Invoke(); }
        if (Input.GetButtonDown(input)) { onButtonDown.Invoke(); }
        if (Input.GetButtonUp(input)) { onButtonUp.Invoke(); }
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public InputActionProperty GripActionValue;
    public InputActionProperty GripAction;
    public InputActionProperty TriggerAction;
    public InputActionProperty TriggerActionValue;
    public bool Gripbutton;
    public float Gripvalue;
    public bool Triggerbutton;
    public float Triggervalue;


    void Update()
    {
        Gripbutton = GripAction.action.IsPressed();
        Gripvalue = GripActionValue.action.ReadValue<float>();
        Triggerbutton = TriggerAction.action.IsPressed();
        Triggervalue = TriggerActionValue.action.ReadValue<float>();

    }
}

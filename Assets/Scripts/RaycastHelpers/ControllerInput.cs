using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/* CONTROLLER INPUT */
public class ControllerInput : MonoBehaviour
{
    [SerializeField] private ActionBasedController leftController;
    [SerializeField] private ActionBasedController rightController;

    public bool GripHasBeenPressed()
    {
        bool buttonWasPressed = false; 

        if (GetGripValue(leftController) == 0.0f || GetGripValue(rightController) == 0.0f)
        {
            buttonWasPressed = true;
        }

        return buttonWasPressed;
    }

    private float GetGripValue(ActionBasedController controller)
    {
        return controller.GetComponent<ActionBasedController>().activateAction.action.ReadValue<float>();
    }
        
}

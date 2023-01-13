using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/* CONTROLLER INPUT */
public class CustomControllerInput : MonoBehaviour
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

    public Vector3 GetLeftHandControllerVectorPosition()
    {
        Vector3 controllerPosition = leftController.transform.position;
        Debug.Log(controllerPosition);
        return controllerPosition;
    }

    public Vector3 GetRightHandControllerVectorPosition()
    {
        Vector3 controllerPosition = rightController.transform.position;
        Debug.Log(controllerPosition);
        return controllerPosition;
    }

    // HELPERS //

    public float GetControllerPosition(ActionBasedController controller)
    {
        return controller.GetComponent<ActionBasedController>().positionAction.action.ReadValue<float>();
    }

    private float GetGripValue(ActionBasedController controller)
    {
        return controller.GetComponent<ActionBasedController>().activateAction.action.ReadValue<float>();
    }
}
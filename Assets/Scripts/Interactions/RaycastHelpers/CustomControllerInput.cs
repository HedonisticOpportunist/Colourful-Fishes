using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/* CUSTOM CONTROLLER INPUT */
public class CustomControllerInput : MonoBehaviour
{
    [SerializeField] private ActionBasedController leftController;
    [SerializeField] private ActionBasedController rightController;

    public Vector3 GetLeftHandControllerPosition()
    {
        Vector3 controllerPosition = leftController.transform.position;
        return controllerPosition;
    }

    public Vector3 GetRightHandControllerPosition()
    {
        Vector3 controllerPosition = rightController.transform.position;
        return controllerPosition;
    } 
}
using UnityEngine;
using UnityEngine.InputSystem;

public class RayCastHelpers : MonoBehaviour
{
    // Variables 
    [SerializeField] private GameObject controlInputManager;
    [SerializeField] EyeGazeFlag eyeGazeFlag;
    private Vector3 position;
  
    private void Update() => HitWithRaycast();

    private void HitWithRaycast()
    {
        bool eyeGaze = eyeGazeFlag.eyeGazeFlag;
        ChangeFishColour(GetRayType(eyeGaze));
    }

    // HELPERS //
    private void ChangeFishColour(Ray ray)
    {
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            ChangeFishColour fishTarget = hit.transform.GetComponent<ChangeFishColour>();

            if (fishTarget != null)
            {
                fishTarget.ChangeColour();
            }
        }
    }

    private Ray GetRayType(bool gaze)
    {
        Ray ray = new(transform.position, transform.forward);

        if (gaze)
        {
            ray = new(Camera.main.transform.position, Camera.main.transform.forward);
        }

        else
        {
            if (controlInputManager.GetComponent<CustomControllerInput>().GripHasBeenPressed())
            {
                position = Mouse.current.position.ReadValue();
                ray = Camera.main.ScreenPointToRay(position);
            }
        }

        return ray;
    }
}

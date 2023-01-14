using UnityEngine;
using UnityEngine.InputSystem;


/* RAYCAST HELPERS */
public class RayCastHelpers : MonoBehaviour
{
    // Variables 
    [SerializeField] private GameObject controlInputManager;
    [SerializeField] EyeGazeFlag eyeGazeFlag;

    // Position variables 
    private Vector3 position;
    private Vector3 startPosition;
    private Vector3 direction;
    
    // Eye Gaze VR flag 
    private bool eyeGaze;

    // Raycast variables
    Ray ray;

    private void Start()
    {
        // Set up start and end position
        startPosition = transform.position;
        direction = transform.forward;

        // Set up the Raycast
        ray = new(startPosition, direction);

        // Set the eye gaze boolean value
        eyeGaze = eyeGazeFlag.eyeGazeFlag;
    }

    private void Update() => HitWithRaycast();

    private void HitWithRaycast()
    {

        ChangeFishColour(GetRayType(eyeGaze, ray));
    }

    // HELPERS //
    private void ChangeFishColour(Ray ray)
    {
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            // Change the colour of the fish 
            ChangeFishColour fishTarget = hit.transform.GetComponent<ChangeFishColour>();

            if (fishTarget != null)
            {
                fishTarget.ChangeColour();
            }
        }
    }

    private Ray GetRayType(bool gaze, Ray raycast)
    {
        if (gaze)
        {
            raycast = new(Camera.main.transform.position, Camera.main.transform.forward);
        }

        else
        {
            if (controlInputManager.GetComponent<CustomControllerInput>().GripHasBeenPressed())
            {

                position = Mouse.current.position.ReadValue();
                raycast = Camera.main.ScreenPointToRay(position);
            }
        }

        return raycast;
    }
}

using UnityEngine;
using UnityEngine.InputSystem;


/* RAYCAST HELPERS */
public class RayCastHelpers : MonoBehaviour
{
    // Variables 
    [SerializeField] EyeGazeFlag eyeGazeFlag;

    // Position variables 
    private Vector3 position;
    private Vector3 startPosition;
    private Vector3 direction;
    
    // Eye Gaze VR flag 
    private bool eyeGaze;

    // Raycast variables
    Ray raycast;

    private void Start()
    {
        // Set up start and end position
        startPosition = transform.position;
        direction = transform.forward;

        // Set up the Raycast
        raycast = new(startPosition, direction);

        // Set the eye gaze boolean value
        eyeGaze = eyeGazeFlag.eyeGazeFlag;
    }

    private void Update() => HitWithRaycast();

    private void HitWithRaycast()
    {

        ChangeFishColour(GetRayType(eyeGaze));
    }

    // HELPERS //
    private void ChangeFishColour(Ray ray)
    {
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Debug.Log(hit.transform.name);

            // Change the colour of the fish 
            ChangeFishColour fishTarget = hit.transform.GetComponent<ChangeFishColour>();

            if (fishTarget != null)
            {
                Debug.Log(hit.transform.name);
                fishTarget.ChangeColour();
            }
        }

        else
        {
            Debug.Log("No object was hit.");
        }
    }

    private Ray GetRayType(bool gaze)
    {
        if (gaze)
        {
            raycast = new(Camera.main.transform.position, Camera.main.transform.forward);
        }

        return raycast;
    }
}

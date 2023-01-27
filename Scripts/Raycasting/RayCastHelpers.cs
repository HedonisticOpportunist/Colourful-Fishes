using UnityEngine;


/* RAYCAST HELPERS */
public class RayCastHelpers : MonoBehaviour
{
    // Variables 
    [SerializeField] EyeGazeFlag eyeGazeFlag;

    // Position variables 
    private Vector3 startPosition;
    private Vector3 direction;

    // Raycast variables
    Ray raycast;

    // Eye Gaze VR flag 
    private bool eyeGaze;

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
        if (eyeGaze == true)
        {
            ChangeFishColour(GetRayType());
        }  
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

    private Ray GetRayType()
    { 
        raycast = new(Camera.main.transform.position, Camera.main.transform.forward);
        return raycast;
    }
}

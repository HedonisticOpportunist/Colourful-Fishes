using UnityEngine;
using UnityEngine.InputSystem;

public class RayCastHelpers : MonoBehaviour
{
    // Variables 
    [SerializeField] private GameObject controlInputManager;
    private bool activateEyeGaze;
    private Vector3 position;

    private void Update()
    {
        if (controlInputManager.GetComponent<CustomControllerInput>().GripHasBeenPressed())
        {
            activateEyeGaze = false;
        }

        else
        {
            activateEyeGaze = true;
        }

       // Debug.Log(activateEyeGaze);
        HitWithRaycast(activateEyeGaze);
    }

    private void HitWithRaycast(bool eyeGaze)
    {
        Ray ray = new(transform.position, transform.forward);

        if (eyeGaze)
        {
            ray = new(Camera.main.transform.position, Camera.main.transform.forward);
        }

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            ChangeFishColour fishTarget = hit.transform.GetComponent<ChangeFishColour>();
            SceneLoader uiTarget = hit.transform.GetComponent<SceneLoader>();

            if (fishTarget != null)
            {
                Debug.Log(hit.transform.name);
                fishTarget.ChangeColour();
            }

            if (uiTarget != null)
            {
                Debug.Log(hit.transform.name);
                uiTarget.LoadScene();
            }

            else
            {
                Debug.Log("Nothing has been hit.");
            }
        }
    }
}

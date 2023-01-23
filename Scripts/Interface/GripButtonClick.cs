using UnityEngine;

/* GRIP BUTTON INTERACTION */
public class GripButtonClick : MonoBehaviour
{
    // Visible fields (within the inspector)
    [SerializeField] private EyeGazeFlag eyeGaze;
    [SerializeField] private GameObject sceneLoader;
    public void OpenGripVRScene()
    {
        // Use the VR gaze
        eyeGaze.eyeGazeFlag = false;
        Debug.Log(" Grip Scene Loaded.");
    }
}


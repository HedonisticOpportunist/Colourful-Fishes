using UnityEngine;

/* GAZE BUTTON INTERACTION */
public class GazeButtonClick : MonoBehaviour
{
    // Visible fields (within the inspector)
    [SerializeField] private EyeGazeFlag eyeGaze;
    [SerializeField] private GameObject sceneLoader;
    public void OpenGazeVRScene()
    {
        // Use the VR gaze
        eyeGaze.eyeGazeFlag = true;
        Debug.Log("Gaze Scene Loaded.");
    }
}

      
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
public class SceneLoader : MonoBehaviour
{
    // Variables

    private XRBaseInteractable interactable;
    [SerializeField] private string changeColour;
    [SerializeField] private EyeGazeFlag eyeGaze;

    protected void OnEnable()
    {
        interactable = GetComponent<XRBaseInteractable>();

        interactable.firstHoverEntered.AddListener(OnFirstHoverEntered);
        interactable.lastHoverExited.AddListener(OnLastHoverExited);
        interactable.firstSelectEntered.AddListener(OnFirstSelectEntered);
        interactable.lastSelectExited.AddListener(OnLastSelectExited);
    }

    protected void OnDisable()
    {
        interactable.firstHoverEntered.RemoveListener(OnFirstHoverEntered);
        interactable.lastHoverExited.RemoveListener(OnLastHoverExited);
        interactable.firstSelectEntered.RemoveListener(OnFirstSelectEntered);
        interactable.lastSelectExited.RemoveListener(OnLastSelectExited);
    }

    protected virtual void OnFirstHoverEntered(HoverEnterEventArgs args) => LoadScene();

    protected virtual void OnLastHoverExited(HoverExitEventArgs args) => LoadScene();

    protected virtual void OnFirstSelectEntered(SelectEnterEventArgs args) => LoadScene();

    protected virtual void OnLastSelectExited(SelectExitEventArgs args) => LoadScene();


    protected void LoadScene()
    {
        Debug.Log(changeColour);

        if (changeColour == "Yes")
        {
            // Use the VR gaze
            eyeGaze.eyeGazeFlag = true;
        }

        if (changeColour == "No")
        {
            // Do not use the VR gaze
            eyeGaze.eyeGazeFlag = false;
        }
       
        SceneManager.LoadScene("GameScene");
    }
}

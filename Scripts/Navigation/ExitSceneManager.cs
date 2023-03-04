using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/* EXIT SCENE SCRIPT */
[RequireComponent(typeof(XRGrabInteractable))]
public class ExitSceneManager : MonoBehaviour
{
    // Variables
    private XRBaseInteractable interactable;

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

    protected virtual void OnFirstHoverEntered(HoverEnterEventArgs args) => ExitScene();

    protected virtual void OnLastHoverExited(HoverExitEventArgs args) => ExitScene();

    protected virtual void OnFirstSelectEntered(SelectEnterEventArgs args) => ExitScene();

    protected virtual void OnLastSelectExited(SelectExitEventArgs args) => ExitScene();


    protected void ExitScene()
    {
        #if UNITY_STANDALONE
            Application.Pause();

        #endif

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}

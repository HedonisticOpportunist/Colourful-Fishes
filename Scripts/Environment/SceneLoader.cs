using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

/* SCENELOADER */

[RequireComponent(typeof(XRGrabInteractable))]
public class SceneLoader : MonoBehaviour
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

    protected virtual void OnFirstHoverEntered(HoverEnterEventArgs args) => LoadScene();

    protected virtual void OnLastHoverExited(HoverExitEventArgs args) => LoadScene();

    protected virtual void OnFirstSelectEntered(SelectEnterEventArgs args) => LoadScene();

    protected virtual void OnLastSelectExited(SelectExitEventArgs args) => LoadScene();


    protected void LoadScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}

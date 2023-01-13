using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class MenuButtonInteraction : MonoBehaviour
{
    // Visible fields (within the inspector)
    [SerializeField] private EyeGazeFlag eyeGaze;
    [SerializeField] private GameObject sceneLoader;

    // Private variables 
    private GraphicRaycaster graphicRaycaster;
    private Vector2 mousePosition;
    private PointerEventData pointerEventData;
    private List<RaycastResult> results;


    private void Start()
    {
        // Get the graphic ray caster 
        graphicRaycaster = GetComponent<GraphicRaycaster>();

        // Set up the pointer events data
        pointerEventData = new(EventSystem.current);

        // Create an empty list of results 
        results = new();
    }

    private void Update()
    {
        // Get the current mouse position 
        mousePosition = Mouse.current.position.ReadValue();

        if (mousePosition != null && graphicRaycaster != null)
        {
            // Assign the pointer events data to the mouse position 
            pointerEventData.position = mousePosition;
            graphicRaycaster.Raycast(pointerEventData, results);

            // Loop through the RaycastResuls list 
            foreach (RaycastResult result in results)
            {
                // Process the result depending on what button has been clicked 
                GetDataFromButtonClick(result);
            }
        }
    }

    private void GetDataFromButtonClick(RaycastResult result)
    {
        if (result.gameObject.CompareTag("GripButton"))
        {
            // Do not use the VR gaze 
            eyeGaze.eyeGazeFlag = false;
            sceneLoader.GetComponent<SceneLoader>().LoadScene();
        }

        if (result.gameObject.CompareTag("GazeButton"))
        {
            // Use the VR gaze
            eyeGaze.eyeGazeFlag = true;
            sceneLoader.GetComponent<SceneLoader>().LoadScene();
        }
    }
}
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class UIInteraction : MonoBehaviour
{
    [SerializeField] private GameObject SceneLoader;
    private GraphicRaycaster graphicRaycaster;

    void Start()
    {
        graphicRaycaster = GetComponent<GraphicRaycaster>();
    }

    void Update()
    {
        // Get the current mouse position 
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        
        if (mousePosition != null && graphicRaycaster != null)
        {
            // Set up the pointer events data
            PointerEventData pointerEventData = new(EventSystem.current);
            pointerEventData.position = mousePosition;

            // Create a list of results 
            List<RaycastResult> results = new();

            graphicRaycaster.Raycast(pointerEventData, results);

            foreach (RaycastResult result in results)
            {
                if (result.gameObject.CompareTag("GripButton"))
                {
                    SceneLoader.GetComponent<SceneLoader>().LoadScene();
                }

                if (result.gameObject.CompareTag("GazeButton"))
                {
                    SceneLoader.GetComponent<SceneLoader>().LoadScene();
                }
            }
        }
    }
}
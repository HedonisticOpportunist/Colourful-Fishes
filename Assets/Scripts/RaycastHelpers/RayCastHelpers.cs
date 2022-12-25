using UnityEngine;

public class RayCastHelpers : MonoBehaviour
{
    // Variables 
    private Vector3 position;
    [SerializeField] private GameObject controlInputManager;

    void Update()
    {
        if (controlInputManager.GetComponent<ControllerInput>().GripHasBeenPressed())
        {
            HitWithRaycast();
        }
    }

    private void HitWithRaycast()
    {
        position = Input.mousePosition;
        //position = Camera.main.transform.forward;
        Ray ray = Camera.main.ScreenPointToRay(position);


        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            ChangeFishColour target = hit.transform.GetComponent<ChangeFishColour>();

            if (target != null)
            {
                Debug.Log(hit.transform.name);
                target.ChangeColour();
            }
        }
    }
}

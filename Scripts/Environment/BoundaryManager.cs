using UnityEngine;

/* BOUNDARY MANAGER */
public class BoundaryManager : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Boundary reached.");
        Destroy(other.gameObject);
    }
}

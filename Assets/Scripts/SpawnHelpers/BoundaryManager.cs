using UnityEngine;

/* BOUNDARY MANAGER */
public class BoundaryManager : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}

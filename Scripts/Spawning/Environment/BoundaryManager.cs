using UnityEngine;

/* BOUNDARY MANAGER SCRIPT */
public class BoundaryManager : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        if (!other.gameObject.CompareTag("SpawnFish"))
        {
            Destroy(other.gameObject);
        }
    }
}

using UnityEngine;

/* BOUNDARY MANAGER */
public class BoundaryManager : MonoBehaviour
{
    void OnTriggerExit(Collider other) => Destroy(other.gameObject);
}

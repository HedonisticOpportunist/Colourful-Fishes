using UnityEngine;

/* CHANGE FISH COLOUR */
public class ChangeFishColour : MonoBehaviour
{
    [SerializeField] private Material changedMaterial; 

    public void ChangeColour()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = changedMaterial;
    }
}

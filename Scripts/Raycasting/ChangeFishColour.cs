using UnityEngine;

/* CHANGE FISH COLOUR SCRIPT */
public class ChangeFishColour : MonoBehaviour
{
    public void ChangeColour()
    {
       
        SwitchColour();
        
    }

    private void SwitchColour()
    {
        // Get the material from the prefab 
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        // Get the colour array 
        Color[] colours = CreateArray();

        // Generate a random integer with parameters within the range of the array 
        int randomIndex = Random.Range(0, colours.Length);

        // Assign the material colour to a random index 
        meshRenderer.material.color = colours[randomIndex];
    }

    private Color[] CreateArray()
    {
        return new Color[] { Color.cyan, Color.green, Color.white, Color.blue, Color.yellow };
    }

}

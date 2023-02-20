using UnityEngine;

/* SPAWN SEA BED OBJECTS SCRIPT */
public class SpawnSeaBedObjects : MonoBehaviour
{
    // Sea plants and seashells
    [SerializeField] private GameObject seaShell;
    [SerializeField] private GameObject grass;

    // Sharks 
    [SerializeField] private GameObject shark;

    // Spawm manager 
    [SerializeField] private GameObject spawnManager;

    private void Start() => SpawnSeaBedItems();


    private void SpawnSeaBedItems()
    {
        spawnManager.GetComponent<SpawningObjects>().SpawnObjects(50, seaShell, 100, false);
        spawnManager.GetComponent<SpawningObjects>().SpawnObjects(50, grass, 100, false);
        spawnManager.GetComponent<SpawningObjects>().SpawnObjects(50, shark, 100, true);
    }
}

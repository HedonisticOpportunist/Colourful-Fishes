using UnityEngine;

/* SPAWN SEA BED OBJECTS */
public class SpawnSeaBedObjects : MonoBehaviour
{
    // Sea plants and seashells
    [SerializeField] private GameObject seaShell;
    [SerializeField] private GameObject grass;

    // Sharks and whales
    [SerializeField] private GameObject shark;
    [SerializeField] private GameObject whale;

    [SerializeField] private GameObject spawnManager;

    private void Start() => SpawnSeaBedItems();


    private void SpawnSeaBedItems()
    {

        spawnManager.GetComponent<SpawningObjects>().SpawnObjects(50, seaShell, 100);
        spawnManager.GetComponent<SpawningObjects>().SpawnObjects(50, grass, 100);

        spawnManager.GetComponent<SpawningObjects>().SpawnObjects(50, shark, 100);
        spawnManager.GetComponent<SpawningObjects>().SpawnObjects(50, whale, 100);
    }
}

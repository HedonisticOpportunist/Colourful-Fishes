using UnityEngine;

/* SPAWN SEA CREATURES SCRIPT */
public class SpawnMenuObjects : MonoBehaviour
{
    // Sea plants and creatures
    [SerializeField] private GameObject waterSkipper;
    [SerializeField] private GameObject turtle;

    // Spawn Manager 
    [SerializeField] private GameObject spawnManager;

    private void Start() => SpawnSeaCreatures();

    private void SpawnSeaCreatures()
    {
        spawnManager.GetComponent<SpawningObjects>().SpawnObjects(50, waterSkipper, 100, false);
        spawnManager.GetComponent<SpawningObjects>().SpawnObjects(50, turtle, 100, false);
    }
}

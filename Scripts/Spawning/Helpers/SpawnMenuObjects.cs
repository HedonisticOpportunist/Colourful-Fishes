using UnityEngine;

/* SPAWN SEA CREATURES */
public class SpawnMenuObjects : MonoBehaviour
{
    // Sea plants and creatures
    [SerializeField] private GameObject waterSkipper;
    [SerializeField] private GameObject turtle;
    [SerializeField] private GameObject spawnManager;

    private void Start() => SpawnSeaCreatures();

    private void SpawnSeaCreatures()
    {
        spawnManager.GetComponent<SpawningObjects>().SpawnObjects(50, waterSkipper, 100);
        spawnManager.GetComponent<SpawningObjects>().SpawnObjects(50, turtle, 100);
    }
}

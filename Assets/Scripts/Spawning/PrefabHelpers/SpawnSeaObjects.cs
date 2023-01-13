using UnityEngine;

/* SPAWN SEA OBJECTS */
public class SpawnSeaObjects : MonoBehaviour
{
    // Sea plants and creatures
    [SerializeField] private GameObject seaShell;
    [SerializeField] private GameObject waterSkipper;
    [SerializeField] private GameObject seaGrass;

    // Fish types
    [SerializeField] private GameObject shark;
    [SerializeField] private GameObject slenderFish;
    [SerializeField] private GameObject averageFish;
    [SerializeField] private GameObject bigFish;
    [SerializeField] private GameObject veryBigFish;

    // Turtles and whales
    [SerializeField] private GameObject turtle;
    [SerializeField] private GameObject whale;


    private void Start()
    {
        SpawnSeaCreatures();
    }

    private void SpawnObjects(GameObject preFab, int numberOfObjects)
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            float positionRange = 50;
            float x = Random.Range(-positionRange, positionRange);
            float y;

            if (preFab.CompareTag("Fish") || preFab.CompareTag("Whale"))
            {
                y = Random.Range(5f, 20);
            }

            else
            {
                y = 0;
            }


            float z = Random.Range(-positionRange, positionRange);

            Instantiate(preFab, new Vector3(x, y, z), preFab.transform.rotation);
        }
    }

    private void SpawnSeaCreatures()
    {

        // Spawn the sea shells and water skippers
        SpawnObjects(seaShell, 100);
        SpawnObjects(waterSkipper, 100);

        // Spawn the sea grass 
        SpawnObjects(seaGrass, 100);

        // Spawn the shark
        SpawnObjects(shark, 100);

        // Spawn the fish
        SpawnObjects(slenderFish, 100);
        SpawnObjects(averageFish, 100);
        SpawnObjects(bigFish, 100);
        SpawnObjects(veryBigFish, 100);

        //Spawn the turtles and whales
        SpawnObjects(whale, 100);
        SpawnObjects(turtle, 100);
    }
}

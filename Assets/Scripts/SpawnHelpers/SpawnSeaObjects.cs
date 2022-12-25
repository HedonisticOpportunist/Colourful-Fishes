using UnityEngine;

/* SPAWN SEA OBJECTS */
public class SpawnSeaObjects : MonoBehaviour
{
    // Sea plants and creatures
    [SerializeField] private GameObject seaShell;
    [SerializeField] private  GameObject waterSkipper;
    [SerializeField] private GameObject seaGrass;

    // Fish types
    [SerializeField] private  GameObject smallFish;
    [SerializeField] private  GameObject bigFish;
    [SerializeField] private  GameObject shark;
    [SerializeField] private  GameObject averageFish;

    // Turtles and whales
    [SerializeField] private GameObject turtle;
    [SerializeField] private GameObject whale;


    void Start()
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

            if (preFab.CompareTag("Fish"))
            {
                y = Random.Range(5f, 20);
            }

            else if (preFab.CompareTag("Whale"))
            {
                y = Random.Range(10f, 20);
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

        // Spawn the fish
        SpawnObjects(smallFish, 100);
        SpawnObjects(bigFish, 100);
        SpawnObjects(shark, 100);
        SpawnObjects(averageFish, 100);

        //Spawn the turtles and whales
        SpawnObjects(whale, 100);
        SpawnObjects(turtle, 100);
    }
}

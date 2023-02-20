
using UnityEngine;

/* SPAWNING OBJECTS SCRIPT */
public class SpawningObjects : MonoBehaviour
{
    public void SpawnObjects(float positionRange, GameObject preFab, int numberOfObjects, bool fish)
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            float x = Random.Range(-positionRange, positionRange);
            float y;
            float z = Random.Range(-positionRange, positionRange);

    
             if (fish)
             {
                y = Random.Range(5f, 20);
             }

             else
             {
                y = 0;
             }

            Instantiate(preFab, new Vector3(x, y, z), preFab.transform.rotation);
        }
    }
}

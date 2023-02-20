using UnityEngine;

/* FLOCK MANAGER SCRIPT
 * Modifed from: https://learn.unity.com/tutorial/flocking 
 */
public class FlockManager : MonoBehaviour 
{
    // Variables
    [SerializeField] private GameObject pinkFish;
    [SerializeField] private GameObject greenFish;

    public static FlockManager FM;
    public GameObject[] allFish;

    public Vector3 swimLimits = new(5.0f, 5.0f, 5.0f);
    public Vector3 goalPos = Vector3.zero;
    public int numFish = 20;

    // Range Settings 
    [Header("Fish Settings")]
    [Range(0.0f, 5.0f)] public float minSpeed;
    [Range(0.0f, 5.0f)] public float maxSpeed;
    [Range(1.0f, 10.0f)] public float neighbourDistance;
    [Range(1.0f, 5.0f)] public float rotationSpeed;

    private void Start()
    {
        InstantiateFish(pinkFish);
        InstantiateFish(greenFish);
    }

    private void Update()
    {
        UpdateSwimmingLimits();
    }


    private void UpdateSwimmingLimits()
    {
        if (Random.Range(0, 100) < 10)
        {

            goalPos = this.transform.position + new Vector3(
                Random.Range(-swimLimits.x, swimLimits.x),
                Random.Range(-swimLimits.y, swimLimits.y),
                Random.Range(-swimLimits.z, swimLimits.z));
        }
    }

    private void InstantiateFish(GameObject fishPrefab)
    {
        allFish = new GameObject[numFish];

        for (int i = 0; i < numFish; ++i)
        {

            Vector3 position = this.transform.position + new Vector3(
                Random.Range(-swimLimits.x, swimLimits.x),
                Random.Range(-swimLimits.y, swimLimits.y),
                Random.Range(-swimLimits.z, swimLimits.z));

            allFish[i] = Instantiate(fishPrefab, position, Quaternion.identity);
        }

        FM = this;
        goalPos = this.transform.position;
    }
}
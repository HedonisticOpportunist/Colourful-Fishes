using UnityEngine;

/* MOVE FISH SCRIPT */

public class MoveFish : MonoBehaviour
{
    // Variables
    private float speed;
    private float time;

    private float minTime;
    private float maxTime;

    private Vector3 randomVector;
    private Quaternion quaternion;

    private void Start()
    {
        // Randomise the speed 
        speed = Random.Range(0.0f, 5.0f);
        SetRandomTime();

        // Initialise time values
        minTime = 2;
        maxTime = 5;
        time = minTime;

    }

    private void Update()
    {

        if (time <= 0)
        {
            RandomRotation();
            transform.rotation = quaternion;
        }

        // Move forward 
        transform.Translate(speed * Time.deltaTime * Vector3.left);
    }

    private void SetRandomTime()
    {
        Random.Range(minTime, maxTime);
    }

    private void RandomRotation()
    {
        randomVector.y = Random.Range(10, 360);
        quaternion = Quaternion.Euler(randomVector);
    }
}

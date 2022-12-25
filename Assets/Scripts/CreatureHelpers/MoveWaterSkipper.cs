using UnityEngine;

/* MOVE WATER CREATURES */
public class MoveWaterSkipper : MonoBehaviour
{
    // Variables
    private float speed; 

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.5f, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Time.deltaTime * speed);
    }
}

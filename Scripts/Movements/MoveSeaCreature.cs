using UnityEngine;

/* MOVE WATER CREATURES SCRIPT */
public class MoveSeaCreature : MonoBehaviour
{
    // Variables
    private float speed;

    private void Start()
    {
        speed = Random.Range(0.5f, 1);
    }

    private void Update()
    {
        transform.Translate(0, 0, Time.deltaTime * speed);
    }
}

using UnityEngine;

/* FLOCK SCRIPT 
 * Modifed from: https://learn.unity.com/tutorial/flocking 
 */
public class Flock : MonoBehaviour
{

    // Variables 
    private float speed;
    private bool turning = false;

    private void Start()
    {

        speed = Random.Range(FlockManager.FM.minSpeed, FlockManager.FM.maxSpeed);
    }


    private void Update()
    {


        if (!new Bounds(FlockManager.FM.transform.position, FlockManager.FM.swimLimits * 2.0f).Contains(transform.position))
        {

            turning = true;
        }

        else
        {

            turning = false;
        }

        if (turning)
        {

            Vector3 direction = FlockManager.FM.transform.position - transform.position;
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.LookRotation(direction),
                FlockManager.FM.rotationSpeed * Time.deltaTime);
        }

        else
        {
            if (Random.Range(0, 100) < 10)
            {
                speed = Random.Range(FlockManager.FM.minSpeed, FlockManager.FM.maxSpeed);
            }


            if (Random.Range(0, 100) < 10)
            {
                ApplyRules();
            }
        }

        this.transform.Translate(0.0f, 0.0f, speed * Time.deltaTime);
    }

    private void ApplyRules()
    {

        GameObject[] gos;
        gos = FlockManager.FM.allFish;

        Vector3 vCentre = Vector3.zero;
        Vector3 vAvoid = Vector3.zero;

        float gSpeed = 0.01f;
        float mDistance;
        int groupSize = 0;

        foreach (GameObject go in gos)
        {

            if (go != this.gameObject && gameObject != null)
            {

                mDistance = Vector3.Distance(go.transform.position, this.transform.position);
                if (mDistance <= FlockManager.FM.neighbourDistance)
                {

                    vCentre += go.transform.position;
                    groupSize++;

                    if (mDistance < 1.0f)
                    {

                        vAvoid += (this.transform.position - go.transform.position);
                    }

                    Flock anotherFlock = go.GetComponent<Flock>();
                    gSpeed += anotherFlock.speed;
                }
            }
        }

        if (groupSize > 0)
        {

            vCentre = vCentre / groupSize + (FlockManager.FM.goalPos - this.transform.position);
            speed = gSpeed / groupSize;

            if (speed > FlockManager.FM.maxSpeed)
            {

                speed = FlockManager.FM.maxSpeed;
            }

            Vector3 direction = (vCentre + vAvoid) - transform.position;
            if (direction != Vector3.zero)
            {

                transform.rotation = Quaternion.Slerp(
                    transform.rotation,
                    Quaternion.LookRotation(direction),
                    FlockManager.FM.rotationSpeed * Time.deltaTime);
            }
        }
    }
}
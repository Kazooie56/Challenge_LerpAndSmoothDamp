using UnityEngine;

public class Cube2Movement : MonoBehaviour
{
    static Vector3 c = new Vector3(1, 1, 0);
    static Vector3 d = new Vector3(1, 3, 0);
    public float smoothTime = 1f;              // Small number = fast, big number = slow

    static Vector3 currentVelocity = Vector3.zero;
    private bool goingToD = true;

    void Start()
    {
        transform.position = c;
    }

    void Update()
    {
        Vector3 target = goingToD ? d : c;

        transform.position = Vector3.SmoothDamp(transform.position, target, ref currentVelocity, smoothTime); // ref lets you change code instead of just copying it. Also might be mandatory when using SmoothDamp.

        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            transform.position = target;

            goingToD = !goingToD; // switch direction
        }
    }

    // Vector3.SmoothDamp(current, target, ref currentVelocity, smoothTime);
    // current is where the object is now
    // target is the goal location
    // 
}

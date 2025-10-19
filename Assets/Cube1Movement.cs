using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Cube1Movement : MonoBehaviour
{
    public Vector3 a = new Vector3 (-1, 1, 0);
    public Vector3 b = new Vector3 (-1, 3, 0);
    float duration = 3f;

    public float timer = 0f;
    private bool goingToB = true;
    
    void Start()
    {
        transform.position = a;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float t = timer / duration;

            if (goingToB)
        {
            transform.position = Vector3.Lerp(a, b, t);
        }

            else
                transform.position = Vector3.Lerp(b, a, t);

            if (timer >= 3)
            {
                timer = 0f;
            if (goingToB == true)
            {
                goingToB = false;

            }
            else
            { goingToB = false == goingToB;}
        }

            //transform.position = Vector3.Lerp(a, b, t); //Time.time / Time.deltaTime 
    }
}
//In Unity, demonstrate two gameobjects moving:

//1) The first gameobject moves from position A to Position B using Vector3.Lerp (you will decide where these 2 positions are - make sure they are in the camera view. 
//Hint: Lerp has 3 parameters. Maybe you can set up a timer to use as one of them? 

//2) The second gameobject moves from position C to position D using Vector3.SmoothDamp -you will have to read the documentation to see how this function works!

//Note: if your unity project is 2D, you would instead use Vector2.Lerp() and Vector2.SmoothDamp()
//Tip:  You may choose to use 2 separate scripts if you desire. 

//Part 2

//Make it so that when the gameobjects reach their target position, they return to their original position, causing the movement to loop. 

//Hint: For Lerp, you can reset your timer so that t becomes 0
//Hint: For SmoothDamp, you will need to check if the gameobject is within a small distance (i.e: 0.01f) from the position D.You can use Vector3.Distance() (or Vector2.Distance()) for this.

//Submission: 

//-Submit link to git repo 
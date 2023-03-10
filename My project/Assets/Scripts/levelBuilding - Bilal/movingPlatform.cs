// made by Bilal

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    this class is used to create a moving platform
    the platform moves from one position to another that is set by the dev
    this platform can go horizontally and vertically 
 */
public class movingPlatform : MonoBehaviour
{

    public Transform startPosition, endPosition; //the start and end points of the moving platform
    public int speed;
    public float timer;
    Vector2 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = endPosition.position; // sets the range of the platform 
    }

    // Update is called once per frame
    public void Update()
    {
        if (Vector2.Distance(transform.position, startPosition.position) < .1f) Invoke("Action1", timer); // checks if the range of the platfrom is less than 1 is so it will start the timer for the action methods 
        if (Vector2.Distance(transform.position, endPosition.position) < .1f) Invoke("Action2", timer);

        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime); // will move the platfrom 
    }
    public void Action1()// these methods set the new target that the platform moves towards
    {
        targetPosition = endPosition.position;
    }
    public void Action2()
    {
        targetPosition = startPosition.position;
    }
}

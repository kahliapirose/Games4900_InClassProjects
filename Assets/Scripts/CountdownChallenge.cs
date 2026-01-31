using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownChallenge : MonoBehaviour
{
    private float waitTime = 1.0f;
    private int startSeconds = 10;
    private float timer = 0f;


    // Adding a bool so once the timer reaches 0 it will stop
    bool timerRunning = true;

    // Making appear into a bool so I can use true or false statements to switch between the sphere being active or not activing (appearing and disapearing)
    bool appear = false;

    private GameObject Cube;

    void Start()
    {
        // Finding my sphere named Cube, pls don't judge me I was too lazy to switch the sphere to a cube after trying to get it to move,  lol
        Cube = GameObject.Find("Cube");

        // Setting the Sphere to it's "disapear state"
        Cube.SetActive(false);

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        // Checking to see if timerRunning is true in a loop
        // Quesetion for the TA/Professor, is it fine to use this may if loops or should I avoid this?
        if (timerRunning)
        {
            //From my understanding Time.deltaTime is the seconds that is take during each frame being added on to the timer vaule.
            timer += Time.deltaTime;
        }

        // Checking if timer is equal to 1
        if (timer >= waitTime)
        {
            // I think this is pretty cool, the "!" alternates appear to true of false after each loop
            appear = !appear;
            // Setting appear to true or false so the cube appears and disappears!
            Cube.SetActive(appear);

            // Printing Timer
            Debug.Log("Time left: " + startSeconds);

            // Reseting Timer
            timer -= waitTime;

            // Decrease startSeconds by -1. Would it also work if I did startSeconds -= 1?
            startSeconds = startSeconds - 1;

            // if loop is checking to see if startSeconds has reached 0
            if (startSeconds <= 0)
            {
                //Printing "TIMES UP" once startSeconds reaches 0
                Debug.Log("TIMES UP");

                // When startSeconds reaches 0 timerRunning is false and the timer will stop.
                timerRunning = false;
            }
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaMovement : MonoBehaviour
{
    public float speed = 10;
    public float currentSpeed;
    public float maxSpeed;
    public float speedIncrease = 5;
    public bool isPaused;
    public bool resetGame = false;
    private Vector3 startPos;

    private void Start()
    {
        startPos = this.transform.position;
        currentSpeed = speed;
    }

    void Update()
    {
        if(!isPaused)
        {
            if (currentSpeed < maxSpeed)
            {
                currentSpeed += speedIncrease * Time.deltaTime;
            }
            transform.position += new Vector3(0, currentSpeed * Time.deltaTime, 0);
        }

        if(resetGame)
        {
            transform.position = startPos;
            resetGame = false;
        }
    }
}

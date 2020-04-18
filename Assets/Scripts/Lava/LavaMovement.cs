using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaMovement : MonoBehaviour
{
    public float speed = 10;
    public bool isPaused;
    public bool resetGame = false;
    private Vector3 startPos;

    private void Start()
    {
        startPos = this.transform.position;
    }

    void Update()
    {
        if(!isPaused)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }

        if(resetGame)
        {
            transform.position = startPos;
        }
    }
}

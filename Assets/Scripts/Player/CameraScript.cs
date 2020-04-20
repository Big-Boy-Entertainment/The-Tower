using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    //------------------------------------------------------------------------
    //Andrei Variables
    public GameObject player;
    //----------------------------------------------------------------
    void Start() { }
    //Andrei Script
    void LateUpdate()
    {
        Vector3 offset = transform.position - player.transform.position;
        bool changeInX = false;
        bool changeInY = false;
        bool changeInZ = false;

        Vector3 newCameraPosition = transform.position;
        if (offset.x > 7)
        {
            changeInX = true;
            newCameraPosition.x = (player.transform.position.x + offset.x) - (offset.x - 7);
        }
        else if (offset.x < -7)
        {
            changeInX = true;
            newCameraPosition.x = (player.transform.position.x + offset.x) - (offset.x + 7);
        }
        if (offset.y > 2)
        {
            changeInY = true;
            newCameraPosition.y = (player.transform.position.y + offset.y) - (offset.y - 2);
        }
        else if (offset.y < -2)
        {
            changeInY = true;
            newCameraPosition.y = (player.transform.position.y + offset.y) - (offset.y + 2);
        }
        if (offset.z > 7)
        {
            changeInZ = true;
            newCameraPosition.z = (player.transform.position.z + offset.z) - (offset.z - 7);
        }
        else if (offset.z < -7)
        {
            changeInZ = true;
            newCameraPosition.z = (player.transform.position.z + offset.z) - (offset.z + 7);
        }
        if (!changeInX)
        {
            newCameraPosition.x = transform.position.x;
        }
        if (!changeInY)
        {
            newCameraPosition.y = transform.position.y;
        }
        if (!changeInZ)
        {
            newCameraPosition.z = transform.position.z;
        }
        transform.position = newCameraPosition;
    }

}

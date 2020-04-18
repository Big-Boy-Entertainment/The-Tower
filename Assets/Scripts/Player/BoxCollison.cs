using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject box;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))

        {

          
            Destroy(box);
        }

    }
}

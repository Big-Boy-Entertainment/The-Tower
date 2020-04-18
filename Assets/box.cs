using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public GameObject Box;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))

        {


            Destroy(Box);
        }

    }
}

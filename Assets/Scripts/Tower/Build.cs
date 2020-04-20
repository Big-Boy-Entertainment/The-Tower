using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{

    private GameObject player;
    public GameObject stairs;
    public GameObject stairsReady;
    private PlayerMovement pMovement;
    private GameObject staircanvas;
    private bool builtstairs;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        pMovement = player.GetComponent<PlayerMovement>();
        stairsReady.SetActive(false);
        staircanvas = GameObject.FindGameObjectWithTag("StairCanvas");
        staircanvas.GetComponent<Canvas>().enabled = false;
        builtstairs = false;

    }

    /*
    private void Update()
    {
        if(pMovement.resources == 0 || stairs.active == false)
        {
            staircanvas.GetComponent<Canvas>().enabled = false;
        }
            
    }
    */


    private void OnTriggerStay(Collider other)
    {

        

        if (pMovement.resources == 0 || builtstairs)
        {
            staircanvas.GetComponent<Canvas>().enabled = false;
        }

        if ( pMovement.resources > 0 && !builtstairs)
        {
            staircanvas.GetComponent<Canvas>().enabled = true;

        }

       




        //staircanvas.SetActive(false);
        if (Input.GetKey(KeyCode.R))
        {
            if(other.gameObject == player)
            {
                if(pMovement.resources > 0)
                {
                    pMovement.resources--;
                    stairsReady.SetActive(true);
                    stairs.SetActive(false);
                    builtstairs = true;
                    staircanvas.GetComponent<Canvas>().enabled = false;

                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{

    private GameObject player;
    private int currentside;
    private bool turnavailable;
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        currentside = 1;
        turnavailable = true;
       

    }

    // Update is called once per frame
    void Update()
    {

        if(currentside == 1)
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -25);
        }
       else if (currentside == 2)
        {
            player.transform.position = new Vector3(25, player.transform.position.y, player.transform.position.z);
        }
      else  if (currentside == 3)
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 25);
        }
      else  if (currentside == 4)
        {
            player.transform.position = new Vector3(-25, player.transform.position.y, player.transform.position.z);
        }

    }



    private void OnTriggerExit(Collider other)
           {
        Collider playerCollider = player.GetComponent<Collider>();

        Vector3 playerPos = player.transform.position;
        if (other == playerCollider && turnavailable)
                    {

            if (player.GetComponent<SpriteRenderer>().flipX == true)
            {
                player.transform.Rotate(0, 90, 0);
                currentside--;
                if (currentside == 0)
                { currentside = 4; }
                
                
                
            }


            if (player.GetComponent<SpriteRenderer>().flipX == false)
            {
                player.transform.Rotate(0, -90, 0);

                currentside++;
                if (currentside == 5)
                { currentside = 1; }
                


            }

          turnavailable = false;

                   
        }

    }


    private void OnTriggerEnter(Collider other)
    {

        Collider playerCollider = player.GetComponent<Collider>();

        if (other == playerCollider)
        {
            turnavailable = true;
        }

    }







}


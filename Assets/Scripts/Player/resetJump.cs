using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class resetJump : MonoBehaviour
{
    /*
    PlayerMovement pMovement;
    public UnityEvent<Collision> collisionEvent;
    private void Start()
    {
        pMovement = this.transform.parent.gameObject.GetComponent<PlayerMovement>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "platform")
        {
            pMovement.isGrounded = true;
            pMovement.anim.SetBool("isGrounded", true);
            pMovement.anim.SetBool("jump", false);
            pMovement.canMove = true;
        }
    }
    */

    //private void OnCollisionStay(Collision collision) => collisionEvent.Invoke(collision); //that just shoves the collision event into the parent, same as OnCollisionStay
    /*{
        if (collision.gameObject.tag == "platform")
        {
            pMovement.isGrounded = true;
            pMovement.anim.SetBool("isGrounded", true);
            pMovement.anim.SetBool("jump", false);
            pMovement.canMove = true;
        }
    }*/
}

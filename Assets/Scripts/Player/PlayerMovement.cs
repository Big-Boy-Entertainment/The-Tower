using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 10f;
    public Vector3 jump;
    public float JumpForce = 2.5f;
    public bool isGrounded;
    Rigidbody rb;
    public Animator anim;
    bool isLeft;
    private GameObject Player;
    public bool isDead = false;
    public float resources;

    public BoxCollider bottomTrig;
    public BoxCollider playerBoxLeft;
    public BoxCollider playerBoxRight;
    public bool canMove;
    public AudioSource walk;
    public AudioSource jumpSound;
    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 4.0f, 0.0f);
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        anim.SetBool("isGrounded", true);
        anim.SetBool("jump", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "END POINT")
        {
            SceneManager.LoadScene(3);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "platform")
        {
            canMove = false;
            Debug.Log(other.gameObject.name);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "platform")
        {
            canMove = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            this.transform.Translate(Speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * JumpForce, ForceMode.Impulse);
            isGrounded = false;
            anim.SetBool("jump", true);
            anim.SetBool("isGrounded", false);
        }
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)  && !isLeft)
        {
            isLeft = true;
            this.GetComponent<SpriteRenderer>().flipX = true;
            Speed = -Speed;
            playerBoxLeft.enabled = true;
            playerBoxRight.enabled = false;
            canMove = true;
        }
        else if(Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A) && isLeft)
        {
            isLeft = false;
            this.GetComponent<SpriteRenderer>().flipX = false;
            Speed = -Speed;
            playerBoxRight.enabled = true;
            playerBoxLeft.enabled = false;
            canMove = true;
        }
        Debug.Log(rb.velocity.y);
    }

    public void playWalk()
    {
        walk.Play();
    }

    public void playJump()
    {
        jumpSound.Play();
    }
}

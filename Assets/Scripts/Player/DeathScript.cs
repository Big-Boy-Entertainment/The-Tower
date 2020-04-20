using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    private GameObject Player;
    public Vector3 death;
    public Vector3 resetPosition;
    public LavaMovement lava;
    public bool deathSceneEnabled;
    public AudioSource deathSound;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        resetPosition = Player.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Player.gameObject)
        {
            Player.GetComponent<PlayerMovement>().isDead = true;
            //if (gc.sfxEnabled)
            //{
            //    Player.GetComponent<AudioSource>().PlayOneShot(deathSound, 0.5f);
            //}

            if (!deathSceneEnabled)
            {
                Player.transform.position = resetPosition;
                lava.resetGame = true;
                deathSound.Play();
            }
            else
            {
                deathSound.Play();
                SceneManager.LoadScene(2);
            }
        }
    }
}

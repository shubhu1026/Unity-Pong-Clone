using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource RacketSound;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            Debug.Log("Racket audio plays");
            this.RacketSound.Play();
        }
        else
        {
            Debug.Log("wall audio plays");
            this.wallSound.Play();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollecting : MonoBehaviour

{
    public AudioSource audioSource;
    public AudioClip coinSound;

    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            collision.gameObject.SetActive(false);
            audioSource.PlayOneShot(coinSound);


        }






        }





    }

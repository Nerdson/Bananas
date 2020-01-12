using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaCollect : MonoBehaviour
{
    public AudioSource pickupSound;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController2D>() == null)
            return;

        pickupSound.Play();

        Destroy(gameObject);
    }
}

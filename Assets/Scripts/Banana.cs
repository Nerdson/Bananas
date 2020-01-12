using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour
{
    public int bananaValue = 1;

    public AudioSource collect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            collect.Play();
            ScoreManager.instance.ChangeScore(bananaValue);
        }
    }
}

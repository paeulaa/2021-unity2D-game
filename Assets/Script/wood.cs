using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wood : MonoBehaviour
{
    private AudioSource audioSource;
    void Start(){
        audioSource = GameObject.Find("wood_s").GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D hit)
    {
        audioSource.Play();
    }
}

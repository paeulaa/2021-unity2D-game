using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlingController : MonoBehaviour
{
    public float health = 4f;
    public static int EnemiesAlive = 0;
    private AudioSource audioSource;

    void Start(){
        EnemiesAlive++;
        audioSource = GameObject.Find("disa_s").GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.relativeVelocity.magnitude > health){
            Die();
        }
    }
    
    void Die(){
        EnemiesAlive--;
        roundController.score = roundController.score + 1;
        audioSource.Play();
        Destroy(gameObject);
    }
}

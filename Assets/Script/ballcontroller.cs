using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroller : MonoBehaviour
{
    Rigidbody2D rb;
    Transform ball;
    public float moveSpeed = 0.8f;
    public static bool isStop = false;
    private AudioSource audioSource;
    private bool isThrow = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ball = GetComponent<Transform>();
        audioSource = GameObject.Find("ball_s").GetComponent<AudioSource>();
        rb.isKinematic = true; 
    }

    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            isThrow = true;
        }
        //float horizontal = Input.GetAxis ("Horizontal");
        if(isThrow){
            //rb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            ball.transform.parent = null; 
            rb.isKinematic = false; 
            rb.AddForce(Vector2.right * moveSpeed,ForceMode2D.Impulse);
        }
    }
    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.layer == 9) audioSource.Play();
    }

}

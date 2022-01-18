using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roundController : MonoBehaviour
{
    public GameObject prefab;
    Canvas scoreCanvas;
    public static int round = 1;
    public static int score = 0;
    public static int score1 = 0;
    public static int score2 = 0;
    public static int score3 = 0;
    GameObject ball;
    GameObject new_ball;
    GameObject hand;
    private float startTime;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    { 
       hand = GameObject.Find("hand"); 
       ball = GameObject.Find("ball");
       scoreCanvas = GameObject.Find("Canvas_hide").GetComponent<Canvas>();
       audioSource = GameObject.Find("pass_s").GetComponent<AudioSource>();
        
        scoreCanvas.enabled = false;
        ball.transform.position = new Vector3(-21.1f, -23.2f, 0.0f);
        ball.transform.localScale = new Vector3(0.5f, 0.5f, 1.0f);
        ball.transform.SetParent(hand.transform, true); 

        startTime = Time.time; 
    }

    // Update is called once per frame
    void Update()
    {
        float f = Time.time - startTime;
        //print(f);
        print(round);  
        if(f > 12.5f){
            if(round < 3){
                delete();
                round++;
                newball();
                startTime = Time.time;
                f =  Time.time - startTime; 
                score = 0;
            }else{
                //Time.timeScale = 0f;
                delete();
                startTime = Time.time;
                f =  Time.time - startTime; 
                score = 0; 
                round++;
            }
        }
        if(round == 1){
            score1 = score;
        }
        else if(round == 2){
            score2 = score;
        }else if(round == 3){
            score3 = score;
        }else if(round == 4){
            audioSource.Play();
            scoreCanvas.enabled = true; 
        }
    }

    void newball(){
        new_ball = GameObject.Instantiate(prefab);
        new_ball.transform.position = new Vector3(-21.1f, -23.2f, 0.0f);
        new_ball.transform.localScale = new Vector3(0.5f, 0.5f, 1.0f);
        new_ball.transform.SetParent(hand.transform, true); 
    }

    void delete(){
        if(round == 1 ){
            Destroy(ball);
        }
        else{
           Destroy(new_ball); 
        }
    }
}

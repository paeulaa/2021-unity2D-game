using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class firstChange : MonoBehaviour
{  
    private AudioSource audioSource;
    void Start(){
        audioSource = GameObject.Find("pass_s").GetComponent<AudioSource>();
    } 
    public void OnLoginButtonCLick(){
        audioSource.Play();
        //Time.timeScale = 1f;
        roundController.round = 1;
        roundController.score = 0;
        roundController.score1 = 0;
        roundController.score2 = 0;
        roundController.score3 = 0;
        // textController.total = 0;
        SceneManager.LoadScene("second");
    }
}

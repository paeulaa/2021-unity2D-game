using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menuChange : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GameObject.Find("button_s").GetComponent<AudioSource>();
        audioSource.clip = clip;
    }
    public void OnLoginButtonCLick(){
        audioSource.Play();
        SceneManager.LoadScene("first"); 
    }
}

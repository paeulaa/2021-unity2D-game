using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ShowScore : MonoBehaviour
{
    public Text ShowScore_t;

    // Update is called once per frame
    void Update()
    {
       ShowScore_t.text = textController.total.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class textController : MonoBehaviour
{
    //public static int score;
    public Text ShowScore1;
    public Text ShowScore2;
    public Text ShowScore3;
    public Text ShowScoretotal;
    public static int total;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        total = (int)roundController.score1 + (int)roundController.score2 + (int)roundController.score3;
        ShowScore1.text = roundController.score1.ToString();
        ShowScore2.text = roundController.score2.ToString();
        ShowScore3.text = roundController.score3.ToString();
        ShowScoretotal.text = total.ToString();
    }
}

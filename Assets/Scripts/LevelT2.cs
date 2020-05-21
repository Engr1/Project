using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelT2 : MonoBehaviour
{
    public int Total;


    void Update()
    {

// Registering Player Score

    Total = ScoreCounter1.Coop + ScoreCounter4.Coop + ScoreCounter5.Coop + mo.Chickens;
    
// Level Transfer Based On Score   

    if(Total >= 802)
    {
        SceneManager.LoadScene("level3");
    }
    }
}

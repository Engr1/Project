using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelT1 : MonoBehaviour
{
    public int Total;


    void Update()
    {
        
// Registering Player Score

    Total =  ScoreCounter4.Coop + ScoreCounter5.Coop + mo.Chickens;

// Level Transfer Based On Score

    if(Total >= 403)
    {
        SceneManager.LoadScene("level2");
    }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter1 : MonoBehaviour
{

// Script For Coop Score Increase

    private int Plus;
    public static int Coop;
    public Text ScoreText;
    public AudioClip CoopRaid,Eating;
    AudioSource audioSource;
    

//Starting Variabls

    void Start()
    {   
        Plus = 1;
        Coop = 0;
        SetScoreText();
        audioSource = GetComponent<AudioSource>();
    }

// Updating Score Text

    void Update()
    {
        SetScoreText();
    }

//Trigger for Coop Score Increase

    private void OnTriggerStay(Collider other)
    {  if(Coop < 400)
         {Coop += Plus;} 
       else
         {Plus = 0;
          Coop = 400;
         }
        audioSource.PlayOneShot(CoopRaid);
        audioSource.PlayOneShot(Eating);
         
    }

//Score Text

    void SetScoreText(){

        ScoreText.text = "Score : 400/" + Coop.ToString();


    }
    
}

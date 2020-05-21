using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreCounter3 : MonoBehaviour
{

// Script For Coop Score Increase
    
    private int Plus;
    public static int Coop;
    public Text ScoreText;
    public AudioClip CoopRaid,Eating;
    AudioSource audioSource;
  


//Starting Variabls

    void Start()
    {   Plus = 1;
        Coop = 0;
        audioSource = GetComponent<AudioSource>();  
        SetScoreText();

    }

// Updating Score Text

    void Update()
    {SetScoreText();

    }

//Trigger for Coop Score Increase

    private void OnTriggerStay(Collider other)
    {  if(Coop < 800)
         {Coop += Plus;} 
       else
         {Plus = 0;
          Coop = 800;
         }
        audioSource.PlayOneShot(CoopRaid);
        audioSource.PlayOneShot(Eating);         
    }

//Score Text

    void SetScoreText(){

        ScoreText.text = "Score : 800/" + Coop.ToString();


    }
    
}

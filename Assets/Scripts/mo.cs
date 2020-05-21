using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mo : MonoBehaviour
{
    public int Total,Plus;
    public Camera cam;
    public UnityEngine.AI.NavMeshAgent agent;
    public Text ScoreText;
    public static int Chickens;
    public AudioClip RipChicken,NightTime;
    AudioSource audioSource;



    void Start()
    {
    // Starting Variables
        agent.speed = 14;
        Plus = 1;
        Chickens = 0;
        SetScoreText();
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(NightTime);
    }


    void Update()

    {

    // Nav Stuff

        agent = GetComponent<NavMeshAgent>();

    // Registering Player Score          
        
        Total = ScoreCounter1.Coop + ScoreCounter2.Coop + ScoreCounter3.Coop +
                ScoreCounter4.Coop + ScoreCounter5.Coop;
    
    // Updating Score Text

        SetScoreText();

    // Click Based Movment
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }   

    //Player Movement Spees Slows Based on Score

        if (Total > 400)
        {
            agent.speed = 12;
        }
        if (Total > 799)
        {
            agent.speed = 7;
        }
        if (Total > 1599)
        {
            agent.speed = 4;
        }

    // Level Transfer Based On Score

        if ( Total > 1800)
        {
        SceneManager.LoadScene("Win");
        }
    
    
    }

    // Nom The Chickens For Score increas

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Chicken")
        {
         Chickens += Plus;
        Destroy(other.gameObject);
        audioSource.PlayOneShot(RipChicken);
        }
    }

    // Chicken Score Text

    void SetScoreText()
    {
        ScoreText.text = "Chickens : " + Chickens.ToString();
    }






}

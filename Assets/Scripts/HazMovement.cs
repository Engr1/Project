using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HazMovement : MonoBehaviour 
{

    public Transform Player;
	int MaxDist = 1;
	int MinDist = 0;
    public int Total;
    private float Speed;
    public GameObject Fox;
    UnityEngine.AI.NavMeshAgent Move;

	void Start()
	{
    // Enemy Movment Speed

        Move.speed = 0;        
    }

	void Update()
	{
    // Nav Mesh Stuff
    
        Move = GetComponent<UnityEngine.AI.NavMeshAgent>();
        Move.SetDestination(Player.transform.position);


    // Make Sure The Enemy Is Facing The Player

        transform.LookAt(Player);
    
    // Registering Player Score

        Total = ScoreCounter1.Coop + ScoreCounter2.Coop + ScoreCounter3.Coop +
                ScoreCounter4.Coop + ScoreCounter5.Coop;


    // Movement Speed Increasing Based On Player Score
        
        if(Total > 799)
        {
           Move.speed = .3f;
        }

        if(Total > 1399)
        {
            
            Move.speed = .6f;
        }

        if(Total > 1999)
        {
            Move.speed = 1.1f;
        }
            


        
        









    }
}
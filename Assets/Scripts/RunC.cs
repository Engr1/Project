using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunC : MonoBehaviour
{
    Rigidbody rb;
    public Transform Player;
	int MaxDist = 7;
	int MinDist = 0;
    public int Total;
    public float Speed;
    public GameObject Fox;

// Starting Variables

	void Start()
	{   
        rb = GetComponent<Rigidbody>();
        Speed = 30f;
        
    }


	void Update()
    {    
    
// Minimum And Maximum Distance Registation For Starting Movment

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
            rb.AddForce(transform.forward * Speed);
            transform.LookAt(2*transform.position - Player.position);
            }
        }
    }

}

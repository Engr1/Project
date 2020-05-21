using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Haz : MonoBehaviour
{
    //A General Player Collider For A Game Over

     void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("lose");
        }
    }
}

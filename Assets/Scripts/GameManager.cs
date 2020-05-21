using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour

{

    // For Buttons

    public void Lose(){SceneManager.LoadScene("Lose");} 
    public void Win(){SceneManager.LoadScene("Win");}    
    public void StartGame(){SceneManager.LoadScene("Level1");} 
    public void Menu(){SceneManager.LoadScene("Menu");} 
    public void Refresh(){SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);}


}

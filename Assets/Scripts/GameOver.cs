using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public PlayerMovement playerMovement;
    public GameObject Player;
    
    public void Start(){
        gameOverScreen.SetActive(false);
    }
    
    public void Update(){
    }
    
    public void GameOverScreen(){
        gameOverScreen.SetActive(true);
        Destroy(Player);
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
}

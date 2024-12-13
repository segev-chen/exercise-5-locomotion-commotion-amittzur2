using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    [SerializeField] private GameObject endScreenText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerWon()
    {
        // show the end screen text
        endScreenText.SetActive(true);
        // set the end screen text to "You Win!"
        endScreenText.GetComponent<EndScreenScript>().enableGameWon();
        // update the high score
        GameObject.Find("HighScoreText").GetComponent<HighScoreScript>().updateHighScore();
    }
    public void PlayerLost()
    {
        // show the end screen text
        endScreenText.SetActive(true);
        // set the end screen text to "Game Over! You lose!"
        endScreenText.GetComponent<EndScreenScript>().enableGameOver();
        // update the high score
        GameObject.Find("HighScoreText").GetComponent<HighScoreScript>().updateHighScore();
    }
}

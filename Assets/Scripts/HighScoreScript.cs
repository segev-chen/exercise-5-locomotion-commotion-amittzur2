using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("HighScore"))
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "High Score: " + PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "High Score: 0";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateHighScore()
    {
        int score = GameObject.Find("ScoreText").GetComponent<ScoreScript>().score;
        if (PlayerPrefs.HasKey("HighScore"))
        {
            if (PlayerPrefs.GetInt("HighScore") < score)
            {
                PlayerPrefs.SetInt("HighScore", score);
                GetComponent<TMPro.TextMeshProUGUI>().text = "High Score: " + PlayerPrefs.GetInt("HighScore");
            }
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", score);
            GetComponent<TMPro.TextMeshProUGUI>().text = "High Score: " + PlayerPrefs.GetInt("HighScore");
        }
    }
}

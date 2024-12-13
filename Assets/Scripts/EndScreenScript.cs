using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void enableGameWon()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "You Win!";
        GetComponent<TMPro.TextMeshProUGUI>().color = Color.green;
    }
    public void enableGameOver()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Game Over! You lose!";
        GetComponent<TMPro.TextMeshProUGUI>().color = Color.red;
    }
}

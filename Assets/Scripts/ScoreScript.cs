using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] public int score = 0;
    [SerializeField] private float comboTimer = 0;
    [SerializeField] private float comboBonus = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Score: " + score;
        comboTimer += Time.deltaTime;

    }
    public void addScore()
    {
        //  it increases the score by 1f + comboBonus / comboTimer
        //(We want to give more points for each Monster the faster the Player kills it)
        //    and resets comboTimer to zero
        score += (int)(1 + comboBonus / comboTimer);
        comboTimer = 0;
    }
}

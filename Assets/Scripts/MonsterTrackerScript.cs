using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTrackerScript : MonoBehaviour
{
    [SerializeField] private int monsterCount = 0;
    [SerializeField] private GameObject endScreenText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addMonster()
    {
        addNMonsters(1);
    }
    public void addNMonsters(int n)
    {
        monsterCount += n;
    }
    public void removeNMonsters(int n)
    {
        monsterCount -= n;
        if(monsterCount < 0)
        {
            monsterCount = 0;
        }
        if (monsterCount == 0) {
            // call the PlayerWon method in the GameOverScript
            GameObject.Find("GameOverManager").GetComponent<GameOverScript>().PlayerWon();

        }
    }
    public void removeMonster()
    {
        removeNMonsters(1);
    }
    public int getMonsterCount()
    {
        return monsterCount;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTotalScripts : MonoBehaviour
{
    [SerializeField] public int lifeTotal;
    [SerializeField] public int initialLifeTotal = 3;
    // Start is called before the first frame update
    void Start()
    {
        lifeTotal = initialLifeTotal;
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeTotal <= 0)
        {
            // check if the object is a monster
            if (gameObject.tag == "Monster")
            {
                // remove the monster
                GameObject.Find("MonsterTracker").GetComponent<MonsterTrackerScript>().removeMonster();
            }
            // destroy self
            Destroy(gameObject);
        }
        // check if the object is out of bounds
        if (transform.position.y < -10)
        {
            if (gameObject.tag == "Monster")
            {
                // remove the monster
                GameObject.Find("MonsterTracker").GetComponent<MonsterTrackerScript>().removeMonster();
            }
            // destroy self
            Destroy(gameObject);

        }

    }
    public void takeDamage(int damage)
    {
        lifeTotal -= damage;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    [SerializeField] private int MaxDamage = 5;
    [SerializeField] private int MinDamage = 1;
    [SerializeField] private string targetTag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == targetTag)
        {
            collision.gameObject.GetComponent<LifeTotalScripts>().takeDamage(Random.Range(MinDamage, MaxDamage));
            // destroy the object
            Destroy(gameObject);
            // if the object is a monster, remove it from the monster tracker
            if (gameObject.tag == "Monster")
            {
                GameObject.Find("MonsterTracker").GetComponent<MonsterTrackerScript>().removeMonster();

            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject monsterPrefab;
    [SerializeField] private int numberOfMonsters = 100;
    // get the terrain
    [SerializeField] private Terrain terrain;
    [SerializeField] private float safeDistance = 10f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfMonsters; i++)
        {
            // get a random position on the terrain
            Vector3 randomPosition = new Vector3(Random.Range(safeDistance, terrain.terrainData.size.x - safeDistance), 0, Random.Range(safeDistance, terrain.terrainData.size.z - safeDistance));
            randomPosition.y = terrain.SampleHeight(randomPosition);
            // create the monster
            GameObject monster = Instantiate(monsterPrefab, randomPosition, Quaternion.identity);
            // activate the monster
            monster.SetActive(true);

        }
        // add n monsters to the monster tracker
        GameObject.Find("MonsterTracker").GetComponent<MonsterTrackerScript>().addNMonsters(numberOfMonsters);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

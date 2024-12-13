using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int waveNumber = 0;
    public GameObject myPrefab;
    public static int score = 0;
    public static int livesLeft = 2;
    public int highScore = 0;
    public GameObject spawnArea;

    void Start()
    {
        if (highScore == 0)
        {
            highScore = PlayerPrefs.GetInt("highScore", 0);
            Debug.Log("High Score is: " + highScore);
        }
        SpawnMoreAndMore();
    }

    public void SpawnOne()
    {

        GameObject newlyCreated =
                    Object.Instantiate(myPrefab);
        // enable the object
        newlyCreated.SetActive(true);
        // Randomly position the newly created object in the spawn area
        newlyCreated.transform.position = new Vector3(
            Random.Range(spawnArea.transform.position.x - spawnArea.transform.localScale.x / 2, spawnArea.transform.position.x + spawnArea.transform.localScale.x / 2),
            Random.Range(spawnArea.transform.position.y - spawnArea.transform.localScale.y / 2, spawnArea.transform.position.y + spawnArea.transform.localScale.y / 2),
            Random.Range(spawnArea.transform.position.z - spawnArea.transform.localScale.z / 2, spawnArea.transform.position.z + spawnArea.transform.localScale.z / 2)
            );
        newlyCreated.transform.LookAt(Camera.main.transform);
    }


    public void SpawnMoreAndMore()
    {
        if (waveNumber > 30)
        {
            return;
        }

        waveNumber += 2;
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnOne();
        }
        Invoke("SpawnMoreAndMore", 3);
    }


    public void EndLife()
    {
        if (livesLeft <= 0)
        {
            Debug.Log("Game Over! You scored " + score);
            if (score > highScore)
            {
                Debug.Log("New High Score!!!");
                highScore = score;
                PlayerPrefs.SetInt("highScore", highScore);
            }
            livesLeft = 2;
            score = 0;
        }
        else
        {
            livesLeft--;
            Debug.Log("Oops! You have " + livesLeft + " lives left");
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * speed,
            Space.World);
        if (transform.position.z >= Camera.main.transform.position.z)
        {
            // print to screen
            Debug.Log("Game Over! You scored " + GameManager.score);
            FindObjectOfType<GameManager>().EndLife();
        }
    }

    public void Select()
    {
        GameManager.score++;
        Debug.Log(GameManager.score);
        Destroy(gameObject);
    }




}
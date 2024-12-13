using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControlScript : MonoBehaviour
{
    [SerializeField] private bool chasePlayer = true;
    [SerializeField] private float monsterTimer = 0f;
    [SerializeField] private float monsterTimerMax = 5f;
    [SerializeField] private GameObject player;
    [SerializeField] private float randomAngle = 0f;
    [SerializeField] private float chasePlayerThreshold = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        monsterTimer += Time.deltaTime;
        if (monsterTimer >= monsterTimerMax)
        {
            // randomize the chasePlayer variable randomly choose a number between 0 and 1 if the number is less than chasePlayerThreshold set chasePlayer to false, otherwise set chasePlayer to true
            chasePlayer = Random.Range(0f, 1f) > chasePlayerThreshold;
            monsterTimer = 0;
            if(!chasePlayer)
            {
                //rotate the Monster around the y axis randomly using
                //Random.Range(do not set the rotation, use Transform.Rotate)
                randomAngle = Random.Range(0, 360);
                
            }
        }
        if(chasePlayer)
        {
            // rotate the Monster around the y axis at a constant rate to face the Player,
            // use Quaternion.LookRotation to get the rotation needed to face the Player
            // use Quaternion.Slerp to smoothly rotate the Monster to face the Player
            Vector3 playerDirection = player.transform.position - transform.position;
            float angle = Vector3.Angle(playerDirection, transform.forward);
            if (angle > 0.1f)
            {
                Quaternion targetRotation = Quaternion.LookRotation(playerDirection);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
            }

        }
        else
        {
            // rotate the Monster around the y axis at a constant rate to face the randomAngle
            // use Quaternion.Euler to set the rotation of the Monster
            Quaternion targetRotation = Quaternion.Euler(0, randomAngle, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
        }

        Vector3 direction = Vector3.forward;
        GetComponent<MovementScript>().direction = direction.normalized;

    }
}

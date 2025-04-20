using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Transform targetTransform; // The target transform to move towards
    public float moveTime = 2.0f; // Time to take to move to the target position
    public float waitTime = 1.0f; // Time to wait at the target position

    // Start is called before the first frame update
    public void ActivateMoveSeq()
    {
        // Start the movement process
        if (targetTransform != null)
        {
            StartCoroutine(MoveToTarget());
        }
        else
        {
            Debug.LogWarning("Target Transform not set in the inspector!");
        }
    }

    // Coroutine to move the object, wait, and move back
    IEnumerator MoveToTarget()
    {
        // Save the initial position of the object
        Vector3 initialPosition = transform.position;
        Vector3 targetPosition = targetTransform.position; // Get the target position from the target transform
        float elapsedTime = 0;

        // Move to the target position over 'moveTime' seconds
        while (elapsedTime < moveTime)
        {
            transform.position = Vector3.Lerp(initialPosition, targetPosition, elapsedTime / moveTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition; // Ensure the final position is exactly the target

        // Wait at the target position for 'waitTime' seconds
        yield return new WaitForSeconds(waitTime);

        // Move back to the original position over 'moveTime' seconds
        elapsedTime = 0;
        while (elapsedTime < moveTime)
        {
            transform.position = Vector3.Lerp(targetPosition, initialPosition, elapsedTime / moveTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = initialPosition; // Ensure the final position is exactly the initial position
    }
}

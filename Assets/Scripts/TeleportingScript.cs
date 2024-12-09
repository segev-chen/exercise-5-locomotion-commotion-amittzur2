using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class TeleportingScript : MonoBehaviour
{
    [SerializeField] static int teleportCount = 0;
    [SerializeField] private int teleportLimit = 3;
    [SerializeField] private GameObject teleportationArea;

    // Start is called before the first frame update
    void Start()
    {
        if (teleportCount >= teleportLimit)
        {
            // remove the Teleportation area script from the object
            teleportationArea.GetComponent<TeleportationArea>().enabled = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Teleport()
    {
        teleportCount++;
        if (teleportCount >= teleportLimit)
        {
            // remove the Teleportation area script from the object
            teleportationArea.GetComponent<TeleportationArea>().enabled = false;
        }
    }

}

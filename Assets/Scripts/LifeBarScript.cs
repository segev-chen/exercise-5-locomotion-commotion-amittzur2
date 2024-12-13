using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBarScript : MonoBehaviour
{
    [SerializeField] private LifeTotalScripts lifeTotalScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "HP: " + lifeTotalScript.lifeTotal + "/" + lifeTotalScript.initialLifeTotal;

    }
}

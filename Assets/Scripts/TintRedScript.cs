using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TintRedScript : MonoBehaviour
{
    [SerializeField] private GameObject body;
    // Start is called before the first frame update
    void Start()
    {
        body.GetComponent<Renderer>().material = Instantiate(body.GetComponent<Renderer>().material);

    }

    // Update is called once per frame
    void Update()
    {
        //get the life total and the initial life total
        int lifeTotal = GetComponent<LifeTotalScripts>().lifeTotal;
        int initialLifeTotal = GetComponent<LifeTotalScripts>().initialLifeTotal;
        float lifeTotalRatio = (float)lifeTotal / initialLifeTotal;
        body.GetComponent<Renderer>().material.color = lifeTotalRatio * Color.white + (1f - lifeTotalRatio) * Color.red;


    }
}

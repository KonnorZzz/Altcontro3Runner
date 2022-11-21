using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterHand : MonoBehaviour
{
    Score score;
    UltTrigger ultTrigger;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Canvas").GetComponent<Score>();
        ultTrigger = GameObject.Find("Ulttrigger1").GetComponent<UltTrigger>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            Destroy(other.gameObject);
            score.score += 1;
            ultTrigger.ult += 1;
        }
    }
}

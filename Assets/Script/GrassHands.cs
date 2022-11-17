using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassHands : MonoBehaviour
{
    Score score;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Canvas").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Grass"))
        {
            Destroy(other.gameObject);
            score.score += 1;
        }
    }
}

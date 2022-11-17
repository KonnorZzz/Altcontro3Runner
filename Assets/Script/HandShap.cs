using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandShap : MonoBehaviour
{
    public List<GameObject> color;
    public int teri;
    public GameObject currentC;


    public List<GameObject> color2;
    public int teri2;
    public GameObject currentC2;

    // Start is called before the first frame update
    void Start()
    {
        currentC = color[teri];
        teri = 0;

        currentC2 = color2[teri2];
        teri2 = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Hand"))
        {
            currentC.SetActive(false);
            currentC = color[teri += 1];
 


            if (currentC == color[3])
            {
               teri = 0;

            }
            currentC.SetActive(true);


            currentC2.SetActive(false);
            currentC2 = color2[teri2 += 1];

            if (currentC2 == color2[3])
            {
                teri2 = 0;
            }
            currentC2.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpSystem : MonoBehaviour
{
    AvatarHP avhp;
    
    
    // Start is called before the first frame update
    void Start()
    {
        avhp = GameObject.Find("Canvas").GetComponent<AvatarHP>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Fire"))
        {
            avhp.health -= 1;
        }

        if (other.CompareTag("Water"))
        {
            avhp.health -= 1;
        }

        if (other.CompareTag("Grass"))
        {
            avhp.health -= 1;
        }
    }
}

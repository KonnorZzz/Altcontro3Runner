using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpSystem : MonoBehaviour
{
    AvatarHP avhp;

    public bool isUlt;

    AudioSource audiosource;


    // Start is called before the first frame update
    void Start()
    {
        avhp = GameObject.Find("Canvas").GetComponent<AvatarHP>();
        isUlt = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Fire")&& isUlt == false)
        {
            avhp.health -= 1;
            GetComponent<AudioSource>().Play();
        }

        if (other.CompareTag("Water")&&isUlt == false)
        {
            avhp.health -= 1;
            GetComponent<AudioSource>().Play();
        }

        if (other.CompareTag("Grass")&& isUlt == false)
        {
            avhp.health -= 1;
            GetComponent<AudioSource>().Play();
        }
    }
}

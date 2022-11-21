using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerSpawn : MonoBehaviour
{    public GameObject spawner2;
    
    void Start()
    {
        spawner2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Appear", 2f);
    }

    void Appear()
    {
        spawner2.SetActive(true);
    }
}

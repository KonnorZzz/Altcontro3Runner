using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    public float speedtime;

    EnemySpawn enemySpawn;


    // Start is called before the first frame update
    void Start()
    {

        enemySpawn = GameObject.Find("EnemySpawner").GetComponent<EnemySpawn>();
        enemySpawn = GameObject.Find("EnemySpawner1").GetComponent<EnemySpawn>();


        speedtime = 0;
    }

    // Update is called once per frame
    void Update()
    {

        speedtime += 1 * Time.deltaTime;

        transform.Translate(0, 0, -1 * speed * Time.deltaTime);

        Invoke("Die", 10);

        
    if (speedtime >= 15 && speedtime <= 35)
            {
                enemySpawn.enemyIntervalMax = 4f;
                enemySpawn.enemyIntervalMin = 3.6f;
            }

    if (speedtime >= 35 && speedtime <= 65)
            {
                enemySpawn.enemyIntervalMax = 2.6f;
                enemySpawn.enemyIntervalMin = 2.4f;
                speed = 0.7f;
            }

    if (speedtime >= 60 && speedtime <= 100)
            {
                enemySpawn.enemyIntervalMax = 2f;
                enemySpawn.enemyIntervalMin = 1.6f;
                speed = 1f;
            }

    if (speedtime >= 100)
            {
                enemySpawn.enemyIntervalMax = 1.2f;
                enemySpawn.enemyIntervalMin = 1f;
                speed = 1f;
            }
        


    }

    public void Die()
    {
        Destroy(gameObject);
    }


}

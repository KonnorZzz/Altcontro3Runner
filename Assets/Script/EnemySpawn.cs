using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject Enemy11;
    [SerializeField]
    private GameObject Enemy22;
    [SerializeField]
    private GameObject Enemy33;


    [SerializeField]
    private GameObject Enemy111;
    [SerializeField]
    private GameObject Enemy222;
    [SerializeField]
    private GameObject Enemy333;


    public List<GameObject> Enemy;

    public List<GameObject> Enemy2;

    public float speedtime;


    //[SerializeField]
    public float enemyIntervalMax = 0.5f;
    public float enemyIntervalMin = 0.1f;

    public float enemyIntervalMax1 = 0.5f;
    public float enemyIntervalMin1 = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        speedtime = 0;

        Enemy[0] = Enemy11;
        Enemy[1] = Enemy22;
        Enemy[2] = Enemy33;

        Enemy2[0] = Enemy111;
        Enemy2[1] = Enemy222;
        Enemy2[2] = Enemy333;


        StartCoroutine(spawnEnemy(Random.Range(enemyIntervalMin, enemyIntervalMax), Enemy11));

        Invoke("Start2", 2f);

        
    }

    private void Update()
    {
        speedtime += 1 * Time.deltaTime;

        if(speedtime <= 15)
        {
            enemyIntervalMax = 4f;
            enemyIntervalMin = 3.6f;

            enemyIntervalMax1 = 4f;
            enemyIntervalMin1 = 3.6f;
        }

        if (speedtime >= 15 && speedtime <= 35)
        {
            enemyIntervalMax = 3.5f;
            enemyIntervalMin = 3f;

            enemyIntervalMax1 = 3.5f;
            enemyIntervalMin1 = 3f;
        }

        if (speedtime >= 35 && speedtime <= 55)
        {
            enemyIntervalMax = 2f;
            enemyIntervalMin = 2f;

            enemyIntervalMax1 = 2f;
            enemyIntervalMin1 = 2f;

        }

        if (speedtime >= 55 && speedtime <= 70)
        {
            enemyIntervalMax = 1.1f;
            enemyIntervalMin = 1f;

            enemyIntervalMax1 = 1.1f;
            enemyIntervalMin1= 1f;

        }

        if (speedtime >= 70 && speedtime <= 100) 
        {
            enemyIntervalMax = 0.5f;
            enemyIntervalMin = 0.5f;

            enemyIntervalMax1 = 0.6f;
            enemyIntervalMin1 = 0.5f;

        }


        if (speedtime >= 100)
        {
            enemyIntervalMax = 0.1f;
            enemyIntervalMin = 0.1f;

            enemyIntervalMax1 = 0.1f;
            enemyIntervalMin1 = 0.1f;

        }
    }

    void Start2()
    {
        StartCoroutine(spawnEnemy2(Random.Range(enemyIntervalMin1, enemyIntervalMax1), Enemy111));
    }

    // Update is called once per frame

    private IEnumerator spawnEnemy(float intervel, GameObject enemy)
    {
        enemy = Enemy[Random.Range(0, 3)];
        yield return new WaitForSeconds(intervel);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(0, 0.3f), Random.Range(0.15f, 0.4f), Random.Range(3, 3)), Quaternion.identity);
        StartCoroutine(spawnEnemy(intervel, enemy));
    }


    private IEnumerator spawnEnemy2(float intervel, GameObject enemy)
    {
        enemy = Enemy[Random.Range(0, 3)];
        yield return new WaitForSeconds(intervel);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-0.3f, 0), Random.Range(0.15f, 0.4f), Random.Range(3, 3)), Quaternion.identity);
        StartCoroutine(spawnEnemy2(intervel, enemy));
    }
}

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


    //[SerializeField]
    public float enemyIntervalMax = 0.5f;
    public float enemyIntervalMin = 0.1f;

    public float enemyIntervalMax1 = 0.5f;
    public float enemyIntervalMin1 = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        Enemy[0] = Enemy11;
        Enemy[1] = Enemy22;
        Enemy[2] = Enemy33;

        Enemy2[0] = Enemy111;
        Enemy2[1] = Enemy222;
        Enemy2[2] = Enemy333;


        StartCoroutine(spawnEnemy(Random.Range(enemyIntervalMin, enemyIntervalMax), Enemy11));

        Invoke("Start2", 2f);

        
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

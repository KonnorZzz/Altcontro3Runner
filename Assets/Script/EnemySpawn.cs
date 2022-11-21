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

    public float x1;
    public float x2;

    public List<GameObject> Enemy;


    //[SerializeField]
    public float enemyIntervalMax = 0.5f;
    public float enemyIntervalMin = 0.1f; 

    // Start is called before the first frame update
    void Start()
    {
        Enemy[0] = Enemy11;
        Enemy[1] = Enemy22;
        Enemy[2] = Enemy33;


        StartCoroutine(spawnEnemy(Random.Range(enemyIntervalMin, enemyIntervalMax), Enemy11));
    }

  

    // Update is called once per frame

    private IEnumerator spawnEnemy(float intervel, GameObject enemy)
    {
        enemy = Enemy[Random.Range(0, 3)];
        yield return new WaitForSeconds(intervel);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(x1, x2), Random.Range(0.15f, 0.4f), Random.Range(3, 3)), Quaternion.identity);
        StartCoroutine(spawnEnemy(intervel, enemy));
    }
}

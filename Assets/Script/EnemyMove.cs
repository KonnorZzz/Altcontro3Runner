using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, 0, -1 * speed * Time.deltaTime);
        Invoke("Die", 10);



    }

    public void Die()
    {
        Destroy(gameObject);
    }


}

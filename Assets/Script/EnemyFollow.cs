using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        target = GameObject.Find("Avatar").GetComponent<Transform>();

        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);


    }
}

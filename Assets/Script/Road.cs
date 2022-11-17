using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public GameObject m_road;
    public float speed;
    Vector3 respawnpos;
    void Start()
    {
        respawnpos.y = -2;
        respawnpos.z = 36;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (transform.position.z < -200)
        {
            respawnpos.x = m_road.transform.position.x;
            transform.position = respawnpos;
        }
    }
}

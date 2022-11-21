using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score = 0;
    [SerializeField] TextMeshProUGUI sc;

    public TextMeshProUGUI PlayerName;


    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        sc.text = "Score:" + score.ToString("0");
        
    }
}

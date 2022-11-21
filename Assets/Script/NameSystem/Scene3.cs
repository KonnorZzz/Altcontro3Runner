using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scene3 : MonoBehaviour
{
    public TextMeshProUGUI FinalScore;
    public int FScore;
    public int score = 0;
    //public Score s;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Awake()
    {
        score = Score.scene3.PlayerScore;
        FinalScore.text = "You Score:" + FScore.ToString("0"); 
    }
}

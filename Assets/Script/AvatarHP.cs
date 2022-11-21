using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AvatarHP : MonoBehaviour
{
    public int health = 15;
    public GameObject GameOver;
    public Score scoreforFinal;
    public int FinalScore;

    [SerializeField] private float time;

    [SerializeField] TextMeshProUGUI hp;
    [SerializeField] TextMeshProUGUI FinalScoreTEXT;
    // Start is called before the first frame update
    void Start()
    {
        GameOver.SetActive(false);
        time = 0;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        hp.text = "HP: " + health.ToString("0");

        FinalScoreTEXT.text = "Your Score: " + FinalScore.ToString("0");


        if (health <= 0)
        {
            health = 0;
        }
        
        if(health == 0)
        {
            //SceneManager.LoadScene(2);
            GameOver.SetActive(true);
            scoreforFinal.score = FinalScore;
           
        }

    }

    private void Update()
    {
        time += 1* Time.deltaTime;

        if(time >= 30)
        {
            health += 1;
            time = 0;
        }
    }

}

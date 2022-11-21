using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneTrigger : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;

    public GameObject color;
    // Start is called before the first frame update
    void Start()
    {
        text1.SetActive(true);
        text2.SetActive(false);

        color.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ToTutorial"))
        {
      
            SceneManager.LoadScene(1);
 
        }

        if (other.CompareTag("ToStart"))
        {
   
            SceneManager.LoadScene(2);
        }

        if (other.CompareTag("ToMenu"))
        {

            SceneManager.LoadScene(0);
        }

        if (other.CompareTag("t1"))
        {
            other.gameObject.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(true);

            color.SetActive(true);

        }
    }
}

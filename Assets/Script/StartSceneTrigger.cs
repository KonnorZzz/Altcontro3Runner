using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}

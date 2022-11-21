using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoMenu : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("Backto", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Backto()
    {
        SceneManager.LoadScene(0);
    }
}

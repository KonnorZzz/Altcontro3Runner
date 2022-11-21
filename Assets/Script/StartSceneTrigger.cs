using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneTrigger : MonoBehaviour
{
    UltTrigger ulttri;
    
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    public GameObject text4;
    public GameObject text5;

    public GameObject text6;

    public GameObject text7;

    public GameObject color;

    public GameObject green;
    public GameObject red;
    public GameObject yellow;

    public GameObject Go1;

    // Start is called before the first frame update
    void Start()
    {
        ulttri = GameObject.Find("Ulttrigger1").GetComponent<UltTrigger>();

        text1.SetActive(true);
        text2.SetActive(false);
        text3.SetActive(false);

        color.SetActive(false);

        green.SetActive(false);
        red.SetActive(false);
        yellow.SetActive(false);

        text4.SetActive(false);
        text5.SetActive(false);
        text6.SetActive(false);
        text7.SetActive(false);

        Go1.SetActive(false);
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

            Invoke("Next1", 6f);

        }
    }

    public void Next1()
    {
        text2.SetActive(false);
        text3.SetActive(true);

        Invoke("Next2", 4f);
        Invoke("Next3", 7f);
        Invoke("Next4", 10f);
    }

    public void Next2()
    {

        green.SetActive(true);
    }

    public void Next3()
    {
       
        yellow.SetActive(true);
    }

    public void Next4()
    {
        text3.SetActive(false);
        red.SetActive(true);
        Invoke("Next5", 10f);
    }

    public void Next5()
    {
        text4.SetActive(true);
        Invoke("Next6", 10f);
    }

    public void Next6()
    {
        text4.SetActive(false);
        text5.SetActive(true);
        color.SetActive(false);
        Invoke("Next7", 10f);
    }

    public void Next7()
    {
        text5.SetActive(false);
        text6.SetActive(true);

        Invoke("Next8", 5f);
    }

    public void Next8()
    {

        ulttri.ult = 70;
        Invoke("Next9", 10f);

    }

    public void Next9()
    {
        text6.SetActive(false);
        text7.SetActive(true);
        Go1.SetActive(true);

    }




}

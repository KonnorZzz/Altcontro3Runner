using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UltTrigger : MonoBehaviour
{
    hpSystem hps;

    public int ult;
    [SerializeField] TextMeshProUGUI ultBar;

    public GameObject ultReadyUI;
    public GameObject Ulthand1;
    public GameObject Ulthand2;

    public bool ultult;

    public GameObject Ultspawner;
    
    
    // Start is called before the first frame update
    void Start()
    {
        ult = 0;

        hps = GameObject.Find("Avatar").GetComponent<hpSystem>();

        ultReadyUI.SetActive(false);
        Ulthand1.SetActive(false);
        Ulthand2.SetActive(false);

        Ultspawner.SetActive(false);


        ultult = true;
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    private void FixedUpdate()
    {
        ultBar.text = ult.ToString("0") + "%";

        if (ult >= 70)
        {
            ult = 70;

        }

        if(ult == 70)
        {
            ultReadyUI.SetActive(true);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("UltTrigger") && ult == 70 && ultult == true)
        {
            
            Ulthand1.SetActive(true);
            Ulthand2.SetActive(true);

            hps.isUlt = true;
            ultult = false;


            Ultspawner.SetActive(true);

            Invoke("UltEnd", 5f);
        }
    }

    void UltEnd()
    {
        ultReadyUI.SetActive(false);
        Ulthand1.SetActive(false);
        Ulthand2.SetActive(false);


        Ultspawner.SetActive(false);

        ult = 0;

        hps.isUlt = false;
        ultult = true;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingHands : MonoBehaviour
{
    public GameObject grassHandLeft;
    public GameObject fireHandLeft;
    public GameObject waterHandLeft;

    public GameObject grassHandRight;
    public GameObject fireHandRight;
    public GameObject waterHandRight; 

    void Start()
    {
        grassHandLeft.SetActive(false);
        fireHandLeft.SetActive(false); 
        waterHandLeft.SetActive(false);

        grassHandRight.SetActive(false); 
        waterHandRight.SetActive (false);
        fireHandRight.SetActive(false); 
    }

    
    void Update()
    {
        
    }

    public void OnGrassLeft()
    {
        fireHandLeft.SetActive(false);
        waterHandLeft.SetActive(false);
        grassHandLeft.SetActive(true);
    }

    public void OnFireLeft()
    {
        waterHandLeft.SetActive(false);
        grassHandLeft.SetActive(false);
        fireHandLeft.SetActive(true); 
    }

    public void OnWaterLeft()
    {
        grassHandLeft.SetActive(false);
        fireHandLeft.SetActive(false);
        waterHandLeft.SetActive(true); 
    }

    //Right Hand
    public void OnGrassRight()
    {
        fireHandRight.SetActive(false);
        waterHandRight.SetActive(false);
        grassHandRight.SetActive(true);
    }

    public void OnFireRight()
    {
        waterHandRight.SetActive(false);
        grassHandRight.SetActive(false);
        fireHandRight.SetActive(true);
    }

    public void OnWaterRight()
    {
        grassHandRight.SetActive(false);
        fireHandRight.SetActive(false);
        waterHandRight.SetActive(true);

        
    }

  
}

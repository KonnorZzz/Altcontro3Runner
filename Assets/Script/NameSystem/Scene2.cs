using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scene2 : MonoBehaviour
{
    public TextMeshProUGUI displayPlayerName;
    public void Awake()
    {
        displayPlayerName.text = "Name:"+ Scene1.scene1.player_name;
    }
}

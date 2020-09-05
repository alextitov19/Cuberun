using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour
{
    public Text scoreText;
    public Text coinsText;

    Player player;


    void Start()
    {
        player = new Player();
        player.LoadData();
        Debug.Log("Player loaded in with SlowMo = " + player.perkSlowMoSelected + ", 2x = " + player.perk2xSelected + ", Invincibility = " + player.perkInvinvibilitySelected);

    }


    void Update()
    {
        player.LoadData();
        scoreText.text = transform.position.z.ToString("0");
        coinsText.text = player.coins.ToString();
    }
}

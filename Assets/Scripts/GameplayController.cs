using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour
{
    public Text scoreText;
    public Text coinsText;
    public Text xpText;

    Player player;


    void Start()
    {
        player = new Player();
        player.LoadData();

    }


    void Update()
    {
        player.LoadData();
        scoreText.text = transform.position.z.ToString("0");
        coinsText.text = player.coins.ToString();
        xpText.text = player.xp.ToString();
    }
}

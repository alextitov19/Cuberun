using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{

    public GameObject perksBackground, skinsBackground;
    public Text coinsText, xpText;

    Player player;

    private void Start()
    {
        player = new Player();
        player.LoadData();
    }

    private void Update()
    {
        player.LoadData();
        coinsText.text = player.coins.ToString();
        xpText.text = player.xp.ToString();
    }
    public void DisplayPerksManu()
    {
        skinsBackground.SetActive(false);
        perksBackground.SetActive(true);
    }

    public void DisplaySkinsMenu()
    {
        perksBackground.SetActive(false);
        skinsBackground.SetActive(true);
    }
}

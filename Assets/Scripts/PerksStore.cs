using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerksStore : MonoBehaviour
{
    public int slowMoPrice, twoxPrice, invincibilityPrice;

    public Text slowMoText, twoxText, invincibilityText;

    Player player;

    private void Start()
    {
        player = new Player();
        player.LoadData();
    }

    private void Update()
    {
        player.LoadData();
        slowMoText.text = player.perkSlowMoAmount.ToString();
        twoxText.text = player.perk2xAmount.ToString();
        invincibilityText.text = player.perkInvinvibilityAmount.ToString();
    }
    public void SlowMoPurchase()
    {
        if (player.coins >= slowMoPrice)
        {
            player.SubtractCoins(slowMoPrice);
            player.AddPerk("SlowMo");
        } else
        {
            Debug.Log("Not enough coins to purchase SlowMoPerk");
        }
    }

    public void TwoxPurchase()
    {
        if (player.coins >= twoxPrice)
        {
            player.SubtractCoins(twoxPrice);
            player.AddPerk("2x");
        }
        else
        {
            Debug.Log("Not enough coins to purchase 2xPerk");
        }
    }

    public void InvincibilityPurchase()
    {
        if (player.coins >= invincibilityPrice)
        {
            player.SubtractCoins(invincibilityPrice);
            player.AddPerk("Invincibility");
        }
        else
        {
            Debug.Log("Not enough coins to purchase InvincibilityPerk");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerksStore : MonoBehaviour
{
    public int slowMoPrice, twoxPrice, invincibilityPrice;

    Player player;

    private void Start()
    {
        player = new Player();
        player.LoadData();
    }

    private void Update()
    {
        player.LoadData();
    }
    public void SlowMoPurchase()
    {
        if (player.coins >= slowMoPrice)
        {
            player.SubtractCoins(slowMoPrice);
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
        }
        else
        {
            Debug.Log("Not enough coins to purchase InvincibilityPerk");
        }
    }
}

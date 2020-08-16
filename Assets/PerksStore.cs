using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerksStore : MonoBehaviour
{
    public Text slowMoText, twoxText, invincibilityText;

    Player player;

    private void Start()
    {
        player = gameObject.GetComponent<Player>();
        player.LoadData();
    }
    public void SlowMoPurchase()
    {
        if (player.coins >= int.Parse(slowMoText.text))
        {
            player.SubtractCoins(int.Parse(slowMoText.text));
        } else
        {
            Debug.Log("Not enough coins to purchase SlowMoPerk");
        }
    }

    public void TwoxPurchase()
    {
        if (player.coins >= int.Parse(twoxText.text))
        {
            player.SubtractCoins(int.Parse(twoxText.text));
        }
        else
        {
            Debug.Log("Not enough coins to purchase 2xPerk");
        }
    }

    public void InvincibilityPurchase()
    {
        if (player.coins >= int.Parse(invincibilityText.text))
        {
            player.SubtractCoins(int.Parse(invincibilityText.text));
        }
        else
        {
            Debug.Log("Not enough coins to purchase InvincibilityPerk");
        }
    }
}

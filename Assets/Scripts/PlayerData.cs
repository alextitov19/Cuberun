using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int coins;
    public int xp;
    public int currentLevel;
    public int perkSlowMoAmount;
    public int perk2xAmount;
    public int perkInvinvibilityAmount;

    public PlayerData(Player player)
    {
        coins = player.coins;
        xp = player.xp;
        currentLevel = player.currentLevel;
        perkSlowMoAmount = player.perkSlowMoAmount;
        perk2xAmount = player.perk2xAmount;
        perkInvinvibilityAmount = player.perkInvinvibilityAmount;
    }
}

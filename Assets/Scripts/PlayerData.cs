using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int coins;
    public int xp;
    public int currentLevel;

    public PlayerData(Player player)
    {
        coins = player.coins;
        xp = player.xp;
        currentLevel = player.currentLevel;
    }
}

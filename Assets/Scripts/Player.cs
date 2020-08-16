using System.Collections;
using UnityEngine;
using System.Xml;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;


public class Player
{


    public int coins;
    public int xp;
    public int currentLevel;

    public void AddCoins(int n)
    {
        Debug.Log("Went into addCoins");
        coins += n;
    }

    public void AddXP(int n)
    {
        xp += n;
    }

    public void SubtractCoins(int n)
    {
        Debug.Log("Went into addCoins");
        coins -= n;
        SaveData();
    }

    public void SubtractXP(int n)
    {
        xp -= n;
        SaveData();
    }

    public void SaveData()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadData()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        coins = data.coins;
        xp = data.xp;
    }
}


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
    public int perkSlowMoAmount;
    public int perk2xAmount;
    public int perkInvinvibilityAmount;
    public int perkSlowMoSelected;
    public int perk2xSelected;
    public int perkInvinvibilitySelected;

    public void AddCoins(int n)
    {
        Debug.Log("Went into addCoins");
        coins += n;
        SaveData();
    }

    public void AddXP(int n)
    {
        xp += n;
        SaveData();
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

    public void AddPerk(string s)
    {
        if(s == "SlowMo")
        {
            perkSlowMoAmount++;
        } else if(s == "2x")
        {
            perk2xAmount++;
        } else if(s == "Invincibility")
        {
            perkInvinvibilityAmount++;
        } else
        {
            Debug.LogError("String s = " + s);
        }
        SaveData();
    }

    public void SubtractPerk(string s)
    {
        if (s == "SlowMo")
        {
            perkSlowMoAmount--;
        }
        else if (s == "2x")
        {
            perk2xAmount--;
        }
        else if (s == "Invincibility")
        {
            perkInvinvibilityAmount--;
        }
        else
        {
            Debug.LogError("String s = " + s);
        }
        SaveData();
    }

    public void SaveData()
    {
        Debug.Log("Went into SaveData");
        SaveSystem.SavePlayer(this);
    }

    public void LoadData()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        coins = data.coins;
        xp = data.xp;
        currentLevel = data.currentLevel;
        perkSlowMoAmount = data.perkSlowMoAmount;
        perk2xAmount = data.perk2xAmount;
        perkInvinvibilityAmount = data.perkInvinvibilityAmount;
        perkSlowMoSelected = data.perkSlowMoSelected;
        perk2xSelected = data.perk2xSelected;
        perkInvinvibilitySelected = data.perkInvinvibilitySelected;
    }
}


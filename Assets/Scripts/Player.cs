using System.Collections;
using UnityEngine;
using System.Xml;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Player : MonoBehaviour
{

    public Text scoreText;
    public Text coinsText;
    public Text xpText;
    public int coins;
    public int xp;
    public int currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        LoadData();

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = transform.position.z.ToString("0");
        coinsText.text = coins.ToString();
        xpText.text = xp.ToString();
    }

    public void AddCoins(int n)
    {
        Debug.Log("Went into addCoins");
        coins += n;
    }

    public void AddXP(int n)
    {
        xp += n;
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


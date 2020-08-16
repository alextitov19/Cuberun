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
        //Debug.Log("Entered SaveData()");
        //playerDataXml.SelectSingleNode("Player/Coins").InnerText = player.coins.ToString();
        //playerDataXml.SelectSingleNode("Player/XP").InnerText = player.xp.ToString();
        //string filePath = "Assets/Resources/playerData.xml";
        //if (File.Exists(filePath))
        //{
        //    Debug.Log("File found at path");
        //    using (TextWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.UTF8)) //Set encoding
        //    {
        //        playerDataXml.Save(sw);
        //    }
        //} else
        //{
        //    Debug.Log("No file at path");
        //}



    }
}


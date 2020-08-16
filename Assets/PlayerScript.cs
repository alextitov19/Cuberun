using System.Collections;
using UnityEngine;
using System.Xml;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    public Text scoreText;
    public Text coinsText;
    public Text xpText;

    XmlDocument playerDataXml;
    XmlElement Coins;
    XmlElement XP;

    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void Awake()
    {
        TextAsset xmlTextAsset = Resources.Load<TextAsset>("playerData");
        playerDataXml = new XmlDocument();
        playerDataXml.LoadXml(xmlTextAsset.text);
        Coins = playerDataXml.SelectSingleNode("Player")["Coins"];
        XP = playerDataXml.SelectSingleNode("Player")["XP"];
        player = new Player
        {
            coins = int.Parse(Coins.InnerText),
            xp = int.Parse(XP.InnerText)
        };
        Debug.Log("Successfully loaded");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = transform.position.z.ToString("0");
        coinsText.text = player.coins.ToString();
        xpText.text = player.xp.ToString();
    }

    public void AddCoins(int n)
    {
        Debug.Log("Went into addCoins");
        player.coins += n;
    }

    public void AddXP(int n)
    {
        player.xp += n;
    }
}


class Player
{
    public int coins, xp, currentLevel;
}
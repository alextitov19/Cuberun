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
        player = new Player
        {
            coins = int.Parse(playerDataXml.SelectSingleNode("Player")["Coins"].InnerText),
            xp = int.Parse(playerDataXml.SelectSingleNode("Player")["XP"].InnerText)
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
}


class Player
{
    public int coins, xp, currentLevel;
}
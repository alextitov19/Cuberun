using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipPerks : MonoBehaviour
{
    public Text slowMoTotalText, twoxTotalText, invincibilityTotalText;
    public Text slowMoSelectedText, twoxSelectedText, invincibilitySelectedText;

    Player player;
    void Start()
    {
        player = new Player();
        player.LoadData();
        slowMoTotalText.text = "Total: " + player.perkSlowMoAmount.ToString();
        twoxTotalText.text = "Total: " + player.perk2xAmount.ToString();
        invincibilityTotalText.text = "Total: " + player.perkInvinvibilityAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddSlowMoPerk()
    {

    }


}

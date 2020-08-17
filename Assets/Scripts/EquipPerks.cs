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
        if(int.Parse(slowMoSelectedText.text) < 3)
        {
            slowMoSelectedText.text = (int.Parse(slowMoSelectedText.text) + 1).ToString();
        }
        else
        {
            Debug.Log("Too many slowmo perks selected; amount selected = " + int.Parse(slowMoSelectedText.text));
        }
    }

    public void SubtractSlowMoPerk()
    {
        if (int.Parse(slowMoSelectedText.text) > 0)
        {
            slowMoSelectedText.text = (int.Parse(slowMoSelectedText.text) - 1).ToString();
        }
        else
        {
            Debug.Log("Too little slowmo perks selected; amount selected = " + int.Parse(slowMoSelectedText.text));
        }
    }


}

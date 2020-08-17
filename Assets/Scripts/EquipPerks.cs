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

    public void Add2xPerk()
    {
        if (int.Parse(twoxSelectedText.text) < 3)
        {
            twoxSelectedText.text = (int.Parse(twoxSelectedText.text) + 1).ToString();
        }
        else
        {
            Debug.Log("Too many 2x perks selected; amount selected = " + int.Parse(twoxSelectedText.text));
        }
    }

    public void Subtract2xPerk()
    {
        if (int.Parse(twoxSelectedText.text) > 0)
        {
            twoxSelectedText.text = (int.Parse(twoxSelectedText.text) - 1).ToString();
        }
        else
        {
            Debug.Log("Too little 2x perks selected; amount selected = " + int.Parse(twoxSelectedText.text));
        }
    }

    public void AddInvincibilityPerk()
    {
        if (int.Parse(invincibilitySelectedText.text) < 3)
        {
            invincibilitySelectedText.text = (int.Parse(invincibilitySelectedText.text) + 1).ToString();
        }
        else
        {
            Debug.Log("Too many invincibility perks selected; amount selected = " + int.Parse(invincibilitySelectedText.text));
        }
    }

    public void SubtractInvincibilityPerk()
    {
        if (int.Parse(invincibilitySelectedText.text) > 0)
        {
            invincibilitySelectedText.text = (int.Parse(invincibilitySelectedText.text) - 1).ToString();
        }
        else
        {
            Debug.Log("Too little invincibility perks selected; amount selected = " + int.Parse(invincibilitySelectedText.text));
        }
    }


}

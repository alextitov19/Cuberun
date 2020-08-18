using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    Player player;

    private void Start()
    {
        player = new Player();
        player.LoadData();
        Debug.Log("Player current level = " + player.currentLevel);
        if(player.currentLevel == 0)
        {
            player.currentLevel = 1;
            player.SaveData();
            Debug.Log("Player current level = " + player.currentLevel);
        }
    }
    public void PlayClicked ()
    {
        SceneManager.LoadScene("EquipPerks");
    }

    public void CustomizeClicked()
    {
        SceneManager.LoadScene("EquipPerks");
    }

    public void StoreClicked()
    {
        SceneManager.LoadScene("Store");
    }
}

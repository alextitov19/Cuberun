using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelComplete : MonoBehaviour
{

    Player player;

    private void Start()
    {
        player = new Player();
        player.LoadData();
        player.currentLevel++;
        player.SaveData();
    }
    public void PlayClicked()
    {
        SceneManager.LoadScene("EquipPerks");
    }

    public void ReturnClicked()
    {
        SceneManager.LoadScene("Menu");
    }
}

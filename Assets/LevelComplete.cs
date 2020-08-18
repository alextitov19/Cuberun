using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelComplete : MonoBehaviour
{
    public void PlayClicked()
    {
        SceneManager.LoadScene("EquipPerks");
    }

    public void ReturnClicked()
    {
        SceneManager.LoadScene("Menu");
    }
}

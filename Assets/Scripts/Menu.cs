using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
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

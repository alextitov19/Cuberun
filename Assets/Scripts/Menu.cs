using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
   public void PlayClicked ()
    {
        SceneManager.LoadScene("Level1");
    }

    public void CustomizeClicked()
    {
        SceneManager.LoadScene("Level1");
    }

    public void StoreClicked()
    {
        SceneManager.LoadScene("Store");
    }
}

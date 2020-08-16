using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{

    public GameObject PerksBackground;
    public GameObject SkinsBackground;
    public void DisplayPerksManu()
    {
        SkinsBackground.SetActive(false);
        PerksBackground.SetActive(true);
    }

    public void DisplaySkinsMenu()
    {
        PerksBackground.SetActive(false);
        SkinsBackground.SetActive(true);
    }
}

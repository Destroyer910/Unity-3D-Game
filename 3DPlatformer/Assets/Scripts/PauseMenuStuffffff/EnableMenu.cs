using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableMenu : MonoBehaviour
{

    [SerializeField] private GameObject areYouSureMenu;

    public void openAreYouSure()
    {
        areYouSureMenu.SetActive(true);
    }

    public void closeAreYouSure()
    {
        areYouSureMenu.SetActive(false);
    }
}

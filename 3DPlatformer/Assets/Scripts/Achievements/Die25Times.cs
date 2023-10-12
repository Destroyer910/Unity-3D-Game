using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Die25Times : MonoBehaviour
{

    [SerializeField] private TotalDeaths totalDeaths;
    public Sprite achievement;
    public TextMeshProUGUI achievementText;
    public string achievementString;

    void Start()
    {
        if(totalDeaths.totalDeaths >= 25)
        {
            gameObject.GetComponent<Image>().sprite = achievement;
            achievementText.text = achievementString;
        }
    }

}

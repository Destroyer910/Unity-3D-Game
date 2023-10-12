using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BirdAchievement : MonoBehaviour
{
    [SerializeField] private SpecialSO specialSO;
    public Sprite achievement;
    public TextMeshProUGUI achievementText;
    public string achievementString;
    // Start is called before the first frame update
    void Start()
    {
        if(specialSO.achievement == "FreeBird")
        {
            gameObject.GetComponent<Image>().sprite = achievement;
            achievementText.text = achievementString;
        }
    }

}

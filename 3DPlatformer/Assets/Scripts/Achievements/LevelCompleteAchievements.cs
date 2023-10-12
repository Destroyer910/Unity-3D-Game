using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelCompleteAchievements : MonoBehaviour
{

    [SerializeField] private IndividualLevelsSO theLevel;
    public Sprite achievement;
    public TextMeshProUGUI achievementText;
    public string achievementString;

    // Start is called before the first frame update
    void Start()
    {
        if(theLevel.beatenLevel)
        {
            gameObject.GetComponent<Image>().sprite = achievement;
            achievementText.text = achievementString;
        }
    }

}

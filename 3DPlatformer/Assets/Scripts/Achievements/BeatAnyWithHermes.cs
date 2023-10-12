using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BeatAnyWithHermes : MonoBehaviour
{

    [SerializeField] private IndividualLevelsSO level1;
    [SerializeField] private IndividualLevelsSO level2;
    [SerializeField] private IndividualLevelsSO level3;
    [SerializeField] private IndividualLevelsSO level4;
    [SerializeField] private IndividualLevelsSO level5;
    public Sprite achievement;
    public TextMeshProUGUI achievementText;
    public string achievementString;

    // Start is called before the first frame update
    void Start()
    {
        if(level1.levelRank == "Hermes Himself" || level2.levelRank == "Hermes Himself" || level3.levelRank == "Hermes Himself" || level4.levelRank == "Hermes Himself" || level5.levelRank == "Hermes Himself")
        {
            gameObject.GetComponent<Image>().sprite = achievement;
            achievementText.text = achievementString;
        }
    }
}

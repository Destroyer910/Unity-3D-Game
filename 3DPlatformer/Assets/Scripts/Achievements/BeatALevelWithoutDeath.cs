using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BeatALevelWithoutDeath : MonoBehaviour
{
    
    [SerializeField] private IndividualLevelsSO level1;
    [SerializeField] private IndividualLevelsSO level2;
    [SerializeField] private IndividualLevelsSO level3;
    [SerializeField] private IndividualLevelsSO level4;
    [SerializeField] private IndividualLevelsSO level5;
    public Sprite achievement;
    public TextMeshProUGUI achievementText;
    public string achievementString;

    void Start()
    {
        if(level1.beatNoDeath || level2.beatNoDeath || level3.beatNoDeath || level4.beatNoDeath || level5.beatNoDeath)
        {
            gameObject.GetComponent<Image>().sprite = achievement;
            achievementText.text = achievementString;
        }
    }

   
}

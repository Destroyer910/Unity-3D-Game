using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCompleteAchievements : MonoBehaviour
{

    [SerializeField] private IndividualLevelsSO theLevel;
    public Sprite achievement;

    // Start is called before the first frame update
    void Start()
    {
        if(theLevel.beatenLevel)
        {
            gameObject.GetComponent<Image>().sprite = achievement;
        }
    }

}

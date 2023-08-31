using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOManagerScript : MonoBehaviour
{
    [SerializeField] private IndividualLevelsSO sampleScene;

    public void updateSampleScene(float time, string rank)
    {
        sampleScene.levelTime = time;
        sampleScene.levelRank = rank;
    }
    public string returnSampleSceneRank(float time)
    {
        if(time <= sampleScene.platReq)
        {
            return "Platinum";
        }
        else if(time <= sampleScene.goldReq)
        {
            return "Gold";
        }
        else if(time <= sampleScene.silverReq)
        {
            return "Silver";
        }
        else if(time <= sampleScene.bronzeReq)
        {
            return "Bronze";
        }
        else
        {
            return "Unranked";
        }
    }
}

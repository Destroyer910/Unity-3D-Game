using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOManagerScript : MonoBehaviour
{
    [SerializeField] private IndividualLevelsSO sampleScene;

    public void updateSampleScene(float time, string rank)
    {
        if(time < sampleScene.levelTime)
        {
            sampleScene.levelTime = time;
            sampleScene.levelRank = rank;
        }
    }
    public string returnSampleSceneRank(float time)
    {
        if(time <= sampleScene.platReq)
        {
            return "Hermes Himself";
        }
        else if(time <= sampleScene.goldReq)
        {
            return "Post Master General";
        }
        else if(time <= sampleScene.silverReq)
        {
            return "Post Man";
        }
        else if(time <= sampleScene.bronzeReq)
        {
            return "Paper Boy";
        }
        else
        {
            return "Your Fired!";
        }
    }

    public float returnRankReqSampleScene(string rank)
    {
        if(rank == "plat")
        {
            return sampleScene.platReq;
        }
        else if(rank == "gold")
        {
            return sampleScene.goldReq;
        }
        else if(rank == "silver")
        {
            return sampleScene.silverReq;
        }
        else
        {
            return sampleScene.bronzeReq;
        }

    }
}

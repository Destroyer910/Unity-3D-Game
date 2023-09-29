using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOManagerScript : MonoBehaviour
{
    [SerializeField] private IndividualLevelsSO level1;
    [SerializeField] private IndividualLevelsSO level2;

    public void updateLevel1(float time, string rank)
    {
        if(time < level1.levelTime)
        {
            level1.levelTime = time;
            level1.levelRank = rank;
            level1.beatenLevel = true;
        }
    }
    public string returnLevel1Rank(float time)
    {
        if(time <= level1.platReq)
        {
            return "Hermes Himself";
        }
        else if(time <= level1.goldReq)
        {
            return "Post Master General";
        }
        else if(time <= level1.silverReq)
        {
            return "Post Man";
        }
        else if(time <= level1.bronzeReq)
        {
            return "Paper Boy";
        }
        else
        {
            return "You're Fired!";
        }
    }

    public float returnRankReqLevel1(string rank)
    {
        if(rank == "plat")
        {
            return level1.platReq;
        }
        else if(rank == "gold")
        {
            return level1.goldReq;
        }
        else if(rank == "silver")
        {
            return level1.silverReq;
        }
        else
        {
            return level1.bronzeReq;
        }

    }

    public void updateLevel2(float time, string rank)
    {
        if(time < level2.levelTime)
        {
            level2.levelTime = time;
            level2.levelRank = rank;
            level2.beatenLevel = true;
        }
    }
    public string returnLevel2Rank(float time)
    {
        if(time <= level2.platReq)
        {
            return "Hermes Himself";
        }
        else if(time <= level2.goldReq)
        {
            return "Post Master General";
        }
        else if(time <= level2.silverReq)
        {
            return "Post Man";
        }
        else if(time <= level2.bronzeReq)
        {
            return "Paper Boy";
        }
        else
        {
            return "You're Fired!";
        }
    }

    public float returnRankReqLevel2(string rank)
    {
        if(rank == "plat")
        {
            return level2.platReq;
        }
        else if(rank == "gold")
        {
            return level2.goldReq;
        }
        else if(rank == "silver")
        {
            return level2.silverReq;
        }
        else
        {
            return level2.bronzeReq;
        }

    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOManagerScript : MonoBehaviour
{
    [SerializeField] private IndividualLevelsSO level1;
    [SerializeField] private IndividualLevelsSO level2;
    [SerializeField] private IndividualLevelsSO level3;
    [SerializeField] private IndividualLevelsSO level4;
    [SerializeField] private IndividualLevelsSO level5;

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

    public void updateLevel3(float time, string rank)
    {
        if(time < level3.levelTime)
        {
            level3.levelTime = time;
            level3.levelRank = rank;
            level3.beatenLevel = true;
        }
    }
    public string returnLevel3Rank(float time)
    {
        if(time <= level3.platReq)
        {
            return "Hermes Himself";
        }
        else if(time <= level3.goldReq)
        {
            return "Post Master General";
        }
        else if(time <= level3.silverReq)
        {
            return "Post Man";
        }
        else if(time <= level3.bronzeReq)
        {
            return "Paper Boy";
        }
        else
        {
            return "You're Fired!";
        }
    }

    public float returnRankReqLevel3(string rank)
    {
        if(rank == "plat")
        {
            return level3.platReq;
        }
        else if(rank == "gold")
        {
            return level3.goldReq;
        }
        else if(rank == "silver")
        {
            return level3.silverReq;
        }
        else
        {
            return level3.bronzeReq;
        }

    }

    public void updateLevel4(float time, string rank)
    {
        if(time < level4.levelTime)
        {
            level4.levelTime = time;
            level4.levelRank = rank;
            level4.beatenLevel = true;
        }
    }
    public string returnLevel4Rank(float time)
    {
        if(time <= level4.platReq)
        {
            return "Hermes Himself";
        }
        else if(time <= level4.goldReq)
        {
            return "Post Master General";
        }
        else if(time <= level4.silverReq)
        {
            return "Post Man";
        }
        else if(time <= level4.bronzeReq)
        {
            return "Paper Boy";
        }
        else
        {
            return "You're Fired!";
        }
    }

    public float returnRankReqLevel4(string rank)
    {
        if(rank == "plat")
        {
            return level4.platReq;
        }
        else if(rank == "gold")
        {
            return level4.goldReq;
        }
        else if(rank == "silver")
        {
            return level4.silverReq;
        }
        else
        {
            return level4.bronzeReq;
        }

    }
    
    public void updateLevel5(float time, string rank)
    {
        if(time < level5.levelTime)
        {
            level5.levelTime = time;
            level5.levelRank = rank;
            level5.beatenLevel = true;
        }
    }
    public string returnLevel5Rank(float time)
    {
        if(time <= level5.platReq)
        {
            return "Hermes Himself";
        }
        else if(time <= level5.goldReq)
        {
            return "Post Master General";
        }
        else if(time <= level5.silverReq)
        {
            return "Post Man";
        }
        else if(time <= level5.bronzeReq)
        {
            return "Paper Boy";
        }
        else
        {
            return "You're Fired!";
        }
    }

    public float returnRankReqLevel5(string rank)
    {
        if(rank == "plat")
        {
            return level5.platReq;
        }
        else if(rank == "gold")
        {
            return level5.goldReq;
        }
        else if(rank == "silver")
        {
            return level5.silverReq;
        }
        else
        {
            return level5.bronzeReq;
        }

    }
}

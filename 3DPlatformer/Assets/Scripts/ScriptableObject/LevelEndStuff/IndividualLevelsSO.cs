using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/EndLevelStuff/IndividualLevels")]
public class IndividualLevelsSO : ScriptableObject
{
    public float levelTime;
    public string levelRank;
    public bool beatenLevel;
    
    public float bronzeReq;
    public float silverReq;
    public float goldReq;
    public float platReq;

    public void findRank()
    {
        if(this.levelTime <= this.platReq)
        {
            this.levelRank =  "Hermes Himself";
        }
        else if(this.levelTime <= this.goldReq && this.levelTime > this.platReq)
        {
            this.levelRank = "Post Master General";
        }
        else if(this.levelTime <= this.silverReq && this.levelTime > this.goldReq)
        {
            this.levelRank = "Post Man";
        }
        else if(this.levelTime <= this.bronzeReq && this.levelTime > this.silverReq)
        {
            this.levelRank = "Paper Boy";
        }
        else
        {
            this.levelRank = "Your Fired!";
        }

    }
}

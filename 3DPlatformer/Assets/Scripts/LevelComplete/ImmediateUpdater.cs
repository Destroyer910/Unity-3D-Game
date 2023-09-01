using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ImmediateUpdater : MonoBehaviour
{

    [SerializeField] private SOManagerScript managerScript;
    [SerializeField] private PreviousLevelSO previousLevel;
    [SerializeField] private StartTimeSO startTime;

    public TextMeshProUGUI levelRank;
    public TextMeshProUGUI levelTime;

    private float targetTime;
    private float currentTime = 0;

    private float platReq;
    private float goldReq;
    private float silverReq;
    private float bronzeReq;

    // Start is called before the first frame update
    void Start()
    {
        levelRank.text = "Hermes Himself";
        targetTime = startTime.time;
        if(previousLevel.previousLevel == "SampleScene")
        {
            managerScript.updateSampleScene(startTime.time, managerScript.returnSampleSceneRank(startTime.time));
            platReq = managerScript.returnRankReqSampleScene("plat");
            goldReq = managerScript.returnRankReqSampleScene("gold");
            silverReq = managerScript.returnRankReqSampleScene("silver");
            bronzeReq = managerScript.returnRankReqSampleScene("bronze");
        }
        
    }

    void Update()
    {
        if(currentTime < targetTime)
        {
            if((currentTime + Time.deltaTime * 10) >= targetTime)
            {
                currentTime = targetTime;
            }
            else
            {
                currentTime += Time.deltaTime * 10;
            }
        }
        TimeSpan timeItself = TimeSpan.FromSeconds(currentTime);
        levelTime.text = timeItself.ToString(@"mm\:ss\:fff");
        
        if((currentTime > platReq) && (currentTime < goldReq))
        {
            levelRank.text = "Post Master General";
        }
        else if((currentTime > goldReq) && (currentTime < silverReq))
        {
            levelRank.text = "Post Man";
        }
        else if((currentTime > silverReq) && (currentTime < bronzeReq))
        {
            levelRank.text = "Paper Boy";
        }
        else if(currentTime > bronzeReq)
        {
            levelRank.text = "Your Fired!";
        }
    }

    
}

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
    [SerializeField] private SpawningSO spawn;

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
        spawn.spawnName = "StartSpawn";
        levelRank.text = "Hermes Himself";
        targetTime = startTime.time;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        if(previousLevel.previousLevel == "Level1")
        {
            managerScript.updateLevel1(startTime.time, managerScript.returnLevel1Rank(startTime.time));
            platReq = managerScript.returnRankReqLevel1("plat");
            goldReq = managerScript.returnRankReqLevel1("gold");
            silverReq = managerScript.returnRankReqLevel1("silver");
            bronzeReq = managerScript.returnRankReqLevel1("bronze");
        }
        else if(previousLevel.previousLevel == "Level2")
        {
            managerScript.updateLevel2(startTime.time, managerScript.returnLevel2Rank(startTime.time));
            platReq = managerScript.returnRankReqLevel2("plat");
            goldReq = managerScript.returnRankReqLevel2("gold");
            silverReq = managerScript.returnRankReqLevel2("silver");
            bronzeReq = managerScript.returnRankReqLevel2("bronze");
        }
        else if(previousLevel.previousLevel == "Level3")
        {
            managerScript.updateLevel3(startTime.time, managerScript.returnLevel3Rank(startTime.time));
            platReq = managerScript.returnRankReqLevel3("plat");
            goldReq = managerScript.returnRankReqLevel3("gold");
            silverReq = managerScript.returnRankReqLevel3("silver");
            bronzeReq = managerScript.returnRankReqLevel3("bronze");
        }
        else if(previousLevel.previousLevel == "Level4")
        {
            managerScript.updateLevel4(startTime.time, managerScript.returnLevel4Rank(startTime.time));
            platReq = managerScript.returnRankReqLevel4("plat");
            goldReq = managerScript.returnRankReqLevel4("gold");
            silverReq = managerScript.returnRankReqLevel4("silver");
            bronzeReq = managerScript.returnRankReqLevel4("bronze");
        }
        else if(previousLevel.previousLevel == "Level5")
        {
            managerScript.updateLevel5(startTime.time, managerScript.returnLevel5Rank(startTime.time));
            platReq = managerScript.returnRankReqLevel5("plat");
            goldReq = managerScript.returnRankReqLevel5("gold");
            silverReq = managerScript.returnRankReqLevel5("silver");
            bronzeReq = managerScript.returnRankReqLevel5("bronze");
        }
        startTime.time = 0;
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

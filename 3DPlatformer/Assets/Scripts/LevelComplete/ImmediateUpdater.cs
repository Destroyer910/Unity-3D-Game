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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/EndLevelStuff/IndividualLevels")]
public class IndividualLevelsSO : ScriptableObject
{
    public float levelTime;
    public string levelRank;
    
    public float bronzeReq;
    public float silverReq;
    public float goldReq;
    public float platReq;
}

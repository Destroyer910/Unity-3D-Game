using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayRankInHub : MonoBehaviour
{
    [SerializeField] private IndividualLevelsSO level;
    public TextMeshPro rank;
    // Start is called before the first frame update
    void Start()
    {
        rank.text = "Rank: " + level.levelRank;
    }
}

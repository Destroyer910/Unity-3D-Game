using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLevelUnlock : MonoBehaviour
{
    
    [SerializeField] private IndividualLevelsSO level;

    void Start()
    {
        gameObject.SetActive(level.beatenLevel);
    }
}

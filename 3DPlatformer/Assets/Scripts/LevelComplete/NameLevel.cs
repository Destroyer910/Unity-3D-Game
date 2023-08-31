using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameLevel : MonoBehaviour
{
    [SerializeField] private PreviousLevelSO previousLevel;
    public TextMeshProUGUI levelName;
    // Start is called before the first frame update
    void Start()
    {
        levelName.text = previousLevel.previousLevel;
    }

}

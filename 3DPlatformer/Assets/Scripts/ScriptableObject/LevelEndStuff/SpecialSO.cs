using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/??/SpecialSO")]
public class SpecialSO : ScriptableObject
{
    public string achievement;

    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
}

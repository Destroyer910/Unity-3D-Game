using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Death/DeathsThisLevel")]
public class DeathsThisLevel : ScriptableObject
{
    public int deathsThisLevel;

    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
}

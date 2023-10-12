using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Death/TotalDeaths")]
public class TotalDeaths : ScriptableObject
{
    public int totalDeaths;

    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
}

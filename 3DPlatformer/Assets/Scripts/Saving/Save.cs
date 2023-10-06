using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Save : MonoBehaviour
{

    [SerializeField] private IndividualLevelsSO level1;
    [SerializeField] private IndividualLevelsSO level2;
    [SerializeField] private IndividualLevelsSO level3;
    [SerializeField] private IndividualLevelsSO level4;
    [SerializeField] private IndividualLevelsSO level5;

    private string directory;
    
    private void Start() {
        directory = Application.dataPath + "/Save.txt";
    }

    public void save()
    {
        File.WriteAllText
        (
            directory,
            level1.levelTime.ToString() + "\n" + 
            level1.beatenLevel.ToString() + "\n" + 
            level2.levelTime.ToString() + "\n" + 
            level2.beatenLevel.ToString() + "\n" + 
            level3.levelTime.ToString() + "\n" + 
            level3.beatenLevel.ToString() + "\n" +
            level4.levelTime.ToString() + "\n" + 
            level4.beatenLevel.ToString() + "\n" +
            level5.levelTime.ToString() + "\n" + 
            level5.beatenLevel.ToString() 
        );

    }

    public void load()
    {
        StreamReader reader = new StreamReader(directory);
        string text = reader.ReadToEnd();

        reader.Close();

        string[] lines = text.Split('\n');
        
        Debug.Log("LOAD");
        //load the tutorial stats to the SO
        level1.levelTime = float.Parse(lines[0]);
        level1.beatenLevel = bool.Parse(lines[1]);
        level1.findRank();
        level2.levelTime = float.Parse(lines[2]);
        level2.beatenLevel = bool.Parse(lines[3]);
        level2.findRank();
        level3.levelTime = float.Parse(lines[4]);
        level3.beatenLevel = bool.Parse(lines[5]);
        level3.findRank();
        level4.levelTime = float.Parse(lines[6]);
        level4.beatenLevel = bool.Parse(lines[7]);
        level4.findRank();
        level5.levelTime = float.Parse(lines[8]);
        level5.beatenLevel = bool.Parse(lines[9]);
        level5.findRank();
    }
    
}

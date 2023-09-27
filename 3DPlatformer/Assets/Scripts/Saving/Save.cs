using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Save : MonoBehaviour
{

    [SerializeField] private IndividualLevelsSO level1;

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
            level1.beatenLevel.ToString()

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
    }
    
}

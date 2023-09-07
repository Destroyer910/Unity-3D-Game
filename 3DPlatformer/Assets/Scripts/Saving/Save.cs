using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Save : MonoBehaviour
{

    [SerializeField] private IndividualLevelsSO tutorial;

    private string directory;
    
    private void Start() {
        directory = Application.dataPath + "/Save.txt";
    }

    public void save()
    {
        File.WriteAllText
        (
            directory,
            tutorial.levelTime.ToString()
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
        tutorial.levelTime = float.Parse(lines[0]);
        tutorial.findRank();
    }
    
}

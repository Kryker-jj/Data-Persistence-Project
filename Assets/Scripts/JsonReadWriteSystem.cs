using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class JsonReadWriteSystem : MonoBehaviour
{
    public int highScore;
    public string highScorer;
    public MainManager manager;
    public GetNameFromMenu nameFromMenu;
    public Text highScorerInfo;

    public void Start()
    {
        LoadFromJson();
    }

    public void Update()
    {
        if (manager.CurrentPoints() > highScore)
        {
            highScore = manager.CurrentPoints();
            highScorer = nameFromMenu.currName;
        }
        highScorerInfo.text = "Best Score : " + highScore + " Name : " + highScorer;
    }

    public void SaveToJson()
    {
        HighScoreInformation data = new HighScoreInformation();
        data.highScore = highScore;
        data.highScorer = highScorer;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/highScorerInformation.json", json);

    }

    public void LoadFromJson()
    {
        if(File.Exists(Application.dataPath + "/highScorerInformation.json"))
        {
            string json = File.ReadAllText(Application.dataPath + "/highScorerInformation.json");
            HighScoreInformation data = JsonUtility.FromJson<HighScoreInformation>(json);

            highScore = data.highScore;
            highScorer = data.highScorer;
        }
        else
        {
            highScore = 0;
            highScorer = "No high scoreer";
        }
    }
}

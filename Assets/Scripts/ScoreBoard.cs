using System.Collections.Generic;
using System.Linq;
using UnityEngine;


[CreateAssetMenu(fileName = "ScoreBoard", menuName = "Scriptable Objects/ScoreBoard")]
    public class ScoreBoard : ScriptableObject
    {
        public float Score {get; private set;}
        public List<float> ScoreArray {get; private set;}

        public void UpdateScore(float score)
    {
        Score = score;
    }

    public void AddScoreBoard(float score)
    {
        ScoreArray.OrderByDescending(x => ScoreArray);
        ScoreArray.Add(score);
        ScoreArray.OrderByDescending(x => ScoreArray);
    }

    public void ResetScore()
    {
        ScoreArray = new List<float>();
    }
}


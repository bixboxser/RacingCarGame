using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int playScore = 0;
    public Text scoreText; 


    // Update is called once per frame
     public void addScore(int score){
        playScore = playScore + score;
        
        scoreText.text =  "Score: " + playScore.ToString();
    }

    void SaveProgress()
    {
        PlayerPrefs.SetInt("Player Score", playScore);
    }

    void LoadProgress()
    {
        playScore = PlayerPrefs.GetInt("Player Score");
    }
}

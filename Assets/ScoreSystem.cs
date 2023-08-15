using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    
    public Text scoreText;
    // public Text highScore;
    public int playerCurrentScore;

    void SetScoreText()
    {
        scoreText.text = "Score: " + playerCurrentScore.ToString();
    }
    // private void Start() {
    //     // highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    // }
    // private void Update() {
    //     if(playerCurrentScore > PlayerPrefs.GetInt("HighScore,0")){
    //         PlayerPrefs.GetInt("HighScore", playerCurrentScore);
    //         highScore.text = "High Score: " + playerCurrentScore.ToString();
    //     }
    // }
    public void SetPlayerSCore(int score){
        playerCurrentScore = score;
        SetScoreText();
    }
}

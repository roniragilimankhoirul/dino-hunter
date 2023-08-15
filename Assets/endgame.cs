using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endgame : MonoBehaviour
{
    public Text scoreText;
    public ScoreSystem scoreSystem;
    public Text HighScoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Your Score: " + Mathf.Round(scoreSystem.playerCurrentScore).ToString();
        
        if (scoreSystem.playerCurrentScore > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", scoreSystem.playerCurrentScore);
        }
        
        float PlayerHighScore = PlayerPrefs.GetFloat("HighScore", 0);
        HighScoreText.text = "High Score : " + Mathf.Round(PlayerHighScore).ToString();
        // if (ScoreManagement.score > PlayerPrefs.GetFloat("HighScore", 0))
        // {
        //     PlayerPrefs.SetFloat("HighScore", ScoreManagement.score);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}

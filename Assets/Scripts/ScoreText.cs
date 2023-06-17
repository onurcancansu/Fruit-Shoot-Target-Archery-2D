using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text highscoreText;
    void Start()
    {
        highscoreText.text = PlayerPrefs.GetInt("Highscore").ToString();
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScore : MonoBehaviour
{
    public int score;
    public int highscore = 0;
    public Text scoreText;
    
    
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Shaft"))
        {
            
            score += 10;
            
            //GetPoints.SetActive(true);
            scoreText.text = score.ToString();
            //highscoreText.text = highscore.ToString();
            if (score > PlayerPrefs.GetInt("Highscore"))
            {

                PlayerPrefs.SetInt("Highscore", score);
            }
        }
        
        


    }

    // Update is called once per frame

}

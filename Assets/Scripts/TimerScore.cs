using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScore : MonoBehaviour
{
    public int time;
    public Text timerText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Timer"))
        {
            time += 10;
            timerText.text = time.ToString();        
        }
    }
}

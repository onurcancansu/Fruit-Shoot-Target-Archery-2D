using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour
{
    [SerializeField] GameObject infomenu;
    public void Pause()
    {
        infomenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        infomenu.SetActive(false);
        Time.timeScale = 1f;
    }
}

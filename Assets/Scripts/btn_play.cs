using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_play : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("PLAY");
    }
}

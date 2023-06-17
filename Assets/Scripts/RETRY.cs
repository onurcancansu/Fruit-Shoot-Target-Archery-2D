using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RETRY : MonoBehaviour
{
    // Start is called before the first frame update
    public void RetryGame()
    {
        SceneManager.LoadScene("PLAY");
    }

    public void Home()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Shop()
    {
        SceneManager.LoadScene("SHOP");
    }
    public void Backward()
    {
        SceneManager.LoadScene("SampleScene");
    }
}


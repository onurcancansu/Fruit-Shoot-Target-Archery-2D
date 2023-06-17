using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BOMB : MonoBehaviour
{

    private AudioSource _audio;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Shaft"))
        {
            //_audio.Play();
            Destroy(gameObject);
            SceneManager.LoadScene("SampleScene");
        }
    }

}

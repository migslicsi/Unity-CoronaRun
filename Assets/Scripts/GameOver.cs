using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.GameOver);
            gameOverPanel.SetActive(true);
        }    
    }

    public void Restart()
    {
        SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Click);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Home()
    {
        SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Click);
        SceneManager.LoadScene(0);
    }
}

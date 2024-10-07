using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause_menu : MonoBehaviour
{
    public string titleScene;

    public GameObject pausePanel;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Pause") && !pausePanel.activeSelf) {
            Debug.Log("paused");
            Pause();
        } else if(Input.GetButtonDown("Pause")) {
            Debug.Log("continued");
            Continue();
        }
    }

    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Title()
    {
        SceneManager.LoadScene(titleScene);
        Time.timeScale = 1;
    }
}

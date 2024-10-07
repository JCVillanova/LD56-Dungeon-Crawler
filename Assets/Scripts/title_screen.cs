using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title_screen : MonoBehaviour
{
    public string gameScene, creditsScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play() 
    {
        SceneManager.LoadScene(gameScene);
    }

    public void Credits()
    {
        SceneManager.LoadScene(creditsScene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

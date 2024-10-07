using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Win();
        }
    }
    public GameObject winPanel;

    public void Win()
    {
        winPanel.SetActive(true);
        Time.timeScale = 0;
    }
}

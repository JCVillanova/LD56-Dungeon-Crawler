using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title_screen_music : MonoBehaviour
{
    public static title_screen_music instance;

    private void Awake()
    {
        if(instance == null) {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }
}

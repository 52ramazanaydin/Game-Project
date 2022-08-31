using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level2 : MonoBehaviour
{
    
    public void Play_btn()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Exit_btn()
    {
        Application.Quit();
    }
}

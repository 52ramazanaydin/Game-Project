using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level4 : MonoBehaviour
{
    
    public void Play_btn()
    {
        SceneManager.LoadScene("Level4");
    }

    public void Exit_btn()
    {
        Application.Quit();
    }
}

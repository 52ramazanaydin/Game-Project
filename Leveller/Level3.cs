using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level3 : MonoBehaviour
{
    
    public void Play_btn()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Exit_btn()
    {
        Application.Quit();
    }
}

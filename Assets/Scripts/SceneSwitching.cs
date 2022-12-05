using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitching : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("LEVEL1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("LEVEL2");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("LEVEL3");
    }
    
}

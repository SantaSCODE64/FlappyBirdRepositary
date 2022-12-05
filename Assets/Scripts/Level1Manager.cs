using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Manager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject levelCompletedPanel;
    void LoadMenu()
    {
        SceneManager.LoadScene("MENU");
    }
    void Update()
    {
        if (OnCollision.Instance.isCollided || OnCollision.Instance.isOut) 
        {
            gameOverPanel.SetActive(true);
            Invoke("LoadMenu", 2f);
        }

        if (GameManager.Instance.numberOfTriggeredPillars == 40)
        {
            levelCompletedPanel.SetActive(true);
            Invoke("LoadMenu", 2f);
        }
    }
}

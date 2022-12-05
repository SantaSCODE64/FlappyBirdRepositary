using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public GameObject pillar;
    public GameObject spawner;
    public GameObject[] pillars;
    public GameObject newPillar;
    public GameObject pausePanel;
    public Rigidbody2D playerRb;
    public Rigidbody2D pillarsRigidbody;
    public int numberOfTriggeredPillars;
    public static bool isTriggered = false;
    public int pillarsNumber = 3;
    public int maxPillars = 40;
    float randNum;

    public List<GameObject> pillarsList = new List<GameObject>();
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.Log("Game Manager is null!!!");
            }
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
    }

    void SpawnPillar()
    {        
        newPillar = Instantiate(pillar, new Vector2(spawner.transform.position.x, randNum), Quaternion.identity);
    }


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


    void Update()
    {
        randNum = Random.Range(-1.6f, 1.6f);

        if (OnTrigger.Instance.isTrigg)
        {
            numberOfTriggeredPillars++;
            OnTrigger.Instance.isTrigg = false;
        }
        
        if (isTriggered == true && pillarsNumber < maxPillars)
        {
            SpawnPillar();
            pillarsNumber++;
            pillarsList.Add(newPillar);
            isTriggered = false;
            pillars = pillarsList.ToArray();
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            pausePanel.SetActive(true);
            playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
            foreach (GameObject pill in pillars)
            {
                pillarsRigidbody = pill.GetComponent<Rigidbody2D>();
                pillarsRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
            }
        }


    }
}

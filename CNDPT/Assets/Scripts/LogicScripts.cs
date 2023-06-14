using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScripts : MonoBehaviour
{
    public Scene scenee;   
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public int levelNumber ;
    public string level;
    public int next;
    public GameObject GameOverScreen;

    [ContextMenu("ADD Score")]
    public void addScore(int i)
    {
        playerScore += i;
        scoreText.text = playerScore.ToString();
    }
    
    //void Awake()
    //{
    //    if(scenee.name == "Level1")
    //    {
    //        levelNumber = 1;
    //    }
    //    else if(scenee.name == "Level2")
    //    {
    //        levelNumber = 2;
    //    }
    //    else if (scenee.name == "Level3")
    //    {
    //        levelNumber = 3;
    //    }
    //    else if (scenee.name == "Level4")
    //    {
    //        levelNumber = 4;
    //    }
    //    else if (scenee.name == "Level5")
    //    {
    //        levelNumber = 5;
    //    }


    //}

    // Update is called once per frame
    void Update()
    {       
        if (playerScore >= 3 && next <= 5) //)
        {   
            NextScene();
        }
        else if (playerScore >= 3 && next == 6)
        {
            GameOverScreen.SetActive(true);

        }
        //else if(playerScore >= 3 && scenee.name == "Level2")
        //{
        //    SceneManager.LoadScene("Level3");
        //    Debug.Log("Nhay sang man 3");
        //}
        //else if (playerScore >= 3 && scenee.name == "Level3")
        //{
        //    SceneManager.LoadScene("Level4");
        //}
        //else if (playerScore >= 3 && scenee.name == "Level4")
        //{
        //    SceneManager.LoadScene("Level5");
        //}
    }
    private void Start()
    {
        next = SceneManager.GetActiveScene().buildIndex + 1;
    }
    void NextScene()
    {
        SceneManager.LoadScene(next);
    }
    
}

using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayUIController : MonoBehaviour
{
    
    //Nút Restart
    public void RestartGame()
    {
        //SceneManager.LoadScene("Level1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }   
    //Nút Home
    public void HomeButton()
    {
        SceneManager.LoadScene("Menu");
    }
      
}

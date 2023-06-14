//BTL CÔNG NGHỆ ĐA PHƯƠNG TIỆN BY PHẠM VIỆT ANH X NGUYỄN DUY VIỆT
//PHẠM VIỆT ANH : 2020605676
//NGUYỄN DUY VIỆT : 2020606223using System.Collections;


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

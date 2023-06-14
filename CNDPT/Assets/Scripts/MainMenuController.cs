//BTL CÔNG NGHỆ ĐA PHƯƠNG TIỆN BY PHẠM VIỆT ANH X NGUYỄN DUY VIỆT
//PHẠM VIỆT ANH : 2020605676
//NGUYỄN DUY VIỆT : 2020606223using System.Collections;


using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Thư viện dùng để quản lý các scene

public class MainMenuController : MonoBehaviour
{
    public LogicScripts logic;
    //Nhớ add scenes vào built-in 
    public void PlayGame()
    {
        //string clickObj = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        //Debug.Log(clickObj);
        //SceneManager.LoadScene("Level1");
        int selectedCharacter = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);// Trả về số thứ tự của nhân vật được chọn trong mảng nhân vật
        GameManager.instance.CharIndex= selectedCharacter;//Trả ra nhân vật được chọn
        SceneManager.LoadScene("Level1");//Đưa người chơi đến cảnh được chọn
        
    }
    //private void Update()
    //{
    //    if (logic.playerScore > 3)
    //    {
    //        SceneManager.LoadScene("Level2");
    //    }
    //}
}

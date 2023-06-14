//BTL CÔNG NGHỆ ĐA PHƯƠNG TIỆN BY PHẠM VIỆT ANH X NGUYỄN DUY VIỆT
//PHẠM VIỆT ANH : 2020605676
//NGUYỄN DUY VIỆT : 2020606223using System.Collections;


using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Event và Delegates
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    private GameObject[] characters;
    private int _charIndex;
    public int CharIndex
    {
        get { return _charIndex; }
        set { _charIndex = value; }
    }
    private void Awake()
    {
        if(instance== null) 
        { 
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);    
        }
        
    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }
    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        if(scene.name != "Menu")//hihi
        {
            Instantiate(characters[CharIndex]);
        }
    }



}

using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Button
using System.Collections.Generic;
using UnityEngine.SceneManagement; //SceneManager

public class GameScenes : MonoBehaviour 
{
    public int sceneIndex; //要載入的Scene
    
    public void ClickEvent()
    {
		//切換到遊戲
        SceneManager.LoadScene(1);
    }

    public void RePlay()
    {
		//切換到起始葉面
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
		//結束遊戲
        Application.Quit();
    }

}
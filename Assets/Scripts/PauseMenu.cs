using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("Game Pause");
    }
    public void Menu(){
        
        //when this is clicked this should also clear game data
        GameManager.instance.ClearGameData();
        Time.timeScale = 1;
        SceneManager.LoadScene(0); //main menu
    }
    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Save(){
        //
    }
    public void Load(){
        //
    }
}

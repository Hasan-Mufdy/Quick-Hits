using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseController : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject mainMenuUI;
    public GameObject inGameInfoUI;
    

    [SerializeField] Button targetButton;
    
    
    // Start is called before the first frame update
    void Start()
    {
        stopTheGame();      // ironic lol
        //Time.timeScale = 1f;
    }

    /////////////////////////////////////////////////////// start menu
    public void startTheGame(){
        Time.timeScale = 1f;
        targetButton.interactable = true;
        inGameInfoUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }
    public void stopTheGame(){    // (after game over)
        Time.timeScale = 0f;
//        targetButton.interactable = false;
//        inGameInfoUI.SetActive(false);
//        mainMenuUI.SetActive(true);



    }
    
    /////////////////////////////////////////////////////////////////////
    // Update is called once per frame
    void Update()
    {
        
    }
    public void pauseGame(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        targetButton.interactable = false;
        //MainMenu.gameIsRunning = false;  //////

    }
    public void resumeGame(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        targetButton.interactable = true;

        //MainMenu.gameIsRunning = true;  ///////
    }
    public void exitToMainMenu(){
        stopTheGame();
        GameController.score = 0;
        SceneManager.LoadScene("Game");
        
    }
}

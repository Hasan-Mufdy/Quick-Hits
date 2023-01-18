using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
   [SerializeField] private Text finalScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        finalScoreText.text = GameController.score.ToString(); 
    }
    public void okBackToMainMenu(){
        SceneManager.LoadScene("Game");
        GameController.score = 0;
    }
    public void Retry(){
        SceneManager.LoadScene("Game");
        GameController.score = 0;
    }
}

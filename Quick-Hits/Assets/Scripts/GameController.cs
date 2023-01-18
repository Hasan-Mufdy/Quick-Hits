using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    // [SerializeField]
    // private Rigidbody2D body;
    private Vector3 pos;
    public static int score = 0;       ///  remove static / add a method  ///
    ///////////////////////
    float timeLeft;
    [SerializeField] float startingTime = 20;
    
    [SerializeField] Text timeLeftText;
    [SerializeField] private Text scoreText;
///////////////////////
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        //startingTime = timeLeft;    // a funny mistake...
        timeLeft = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        decreaseTimeCounter();

    }
    public void changePos(){
        Vector2 randomPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        gameObject.transform.localPosition = randomPos;
        
        // increase score fter changing the position
        score++;
        scoreText.text = "Score: " + score;   
        
    }
    public void decreaseScore(){
        if(score > 0){
        score = score - 1;
        scoreText.text = "Score: " + score;
        }
    }
    void decreaseTimeCounter(){
        timeLeft -= 1 * Time.deltaTime;
        timeLeftText.text = "Time Left: " + timeLeft.ToString("0.0");   // 0.0 is the format which will be shown
        if(timeLeft <=0){
            SceneManager.LoadScene("GameOver");
        }
    }

}

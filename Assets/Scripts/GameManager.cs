using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public AudioSource theMusic;
    public bool startPlaying;
    public BeatScroller theBS;
    public EnemyCar theCar;
    public static GameManager instance;

    public int currentScore;
    public int scorePerNote = 100;
    public int scorePerGoodNote = 125;
    public int scorePerPerfectNote = 200;

    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThresholds;

    public Text scoreText;
    public Text multiText;

    public GameObject resultsScreen;
    //player move
    //public float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(CountdownToStart());
        instance = this;
        scoreText.text = "Score : 0";
        currentMultiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // if(!startPlaying){
        //     if(Input.anyKeyDown){
        //         startPlaying = true;
        //         //CountdownToStart();
        //         theBS.hasStarted = true;
        //         //theCar.hasStarted = true;
        //         theMusic.Play();
        //     }
        // }
        beginGame();
    }

    public void beginGame(){
        // Countdown.instance.CountdownToStart();
        if(!startPlaying){
            Countdown.instance.CountdownToStart();
            if(Input.anyKeyDown){
                
                startPlaying = true;
                theBS.hasStarted = true;
                // theCar.hasStarted = true;
                theMusic.Play();
            }
        }
        // else{
        //     if(!theMusic.isPlaying && !resultsScreen.activeInHierarchy){
        //         resultsScreen.SetActive(true);
        //     }
        // }
    }

    public void NoteHit (){
        // Debug.Log("Perfect");

        //not work yet
        if (currentMultiplier - 1 < multiplierThresholds.Length){

            multiplierTracker++;

            if(multiplierThresholds[currentMultiplier - 1] <= multiplierTracker){
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }

        multiText.text = "Combo x "+currentMultiplier;

        // currentScore = scorePerNote + currentScore;
        // currentScore += scorePerNote * currentMultiplier;
        scoreText.text = "Score : " +currentScore; 
        // Debug.Log(currentScore);
    }

    public void NormalHit(){
        currentScore += scorePerNote; 
        // * currentMultiplier;
        NoteHit();
    }

    public void GoodHit(){
        currentScore += scorePerGoodNote; 
        // * currentMultiplier;
        NoteHit();
    }

    public void PerfectHit(){
        currentScore += scorePerPerfectNote; 
        // * currentMultiplier;
        NoteHit();
    }

    public void NoteMissed(){
        Debug.Log("Miss!");

        currentMultiplier = 1;
        multiplierTracker =0;
        multiText.text = "Combo 1x";
    }

    public void Garage() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Garage1() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void Garage2() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
    
}

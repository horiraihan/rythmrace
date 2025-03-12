using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    public Sprite Red4;
    public Sprite Green3;
    private SpriteRenderer checkpointSpriteRenderer;

    public GameObject resultsScreen, resultsScreenLose;
    public bool isPaused;
    public bool checkPointReached;


    void Start()
    {
        checkpointSpriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag== "Player"){
            checkpointSpriteRenderer.sprite = Green3;
            resultsScreen.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
            Debug.Log("Anda Menang");
        }
        else {
            checkpointSpriteRenderer.sprite = Green3;
            // resultsScreenLose.SetActive(true);
            Debug.Log("Anda Kalah");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    PlayerController playerController;
    EnemyController enemyController;
    public bool startPlaying;
    public bool hasStarted;

    public static CarController instance;

    private Animator playerAnimation;
    private Rigidbody2D rigidBody;

    
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<Animator>();
        GameObject gameController = GameObject.FindGameObjectWithTag("PlayerController");
        GameObject AIController = GameObject.FindGameObjectWithTag("EnemyController");
        enemyController = AIController.GetComponent<EnemyController>();
        playerController = gameController.GetComponent<PlayerController>();
    }

    void Update()
    {
        move();
        moveEnemy();     
    }


    public void move(){
        transform.Translate(playerController.moveVector * playerController.speed * Time.deltaTime);
    }

    public void moveEnemy(){
        transform.Translate(enemyController.moveVector * enemyController.speed * Time.deltaTime);
    }

    //finish detector
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "FinishDetector"){
            Debug.Log("anda menang");
        }
    }
}

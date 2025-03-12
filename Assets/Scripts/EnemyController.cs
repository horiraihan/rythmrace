using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 0f; //movespeed
    private float movement = 0f;

    public Vector3 moveVector;
    // public NoteObject canBePressed;
    public GameManager currentMultiplier;



    // private Animator playerAnimation;
    // private Rigidbody2D rigidBody;
    void Start()
    {
        // rigidBody = GetComponent<Rigidbody2D>();
        // playerAnimation = GetComponent<Animator>();
        
    }

    void Update()
    {
        move();

        // playerAnimation.SetFloat("Speed", rigidBody.velocity.x);
        // CarController.instance.animation();
    }

    // void enemy (){
    //     speed = 4.5f;
    // }

    void move(){
        movement = (float) GameManager.instance.currentMultiplier;

        if (movement > 1){
            speed = 4.5f;
        }else if ( movement == 1){

            speed= 0f;
            Debug.Log ("ANGKOT MOGOK!");
        }
    }

    
}

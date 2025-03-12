using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0f; //movespeed
    private float movement = 0f;

    public EnemyCar theCar;

    public Vector3 moveVector;
    public GameManager currentMultiplier;
    void Start()
    {
        
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
            theCar.hasStarted = true;
            speed = 4.5f;
        }
        else if ( movement == 1){
            speed= 0f;
            Debug.Log ("ANGKOT MOGOK!");
        }
    }

    
}

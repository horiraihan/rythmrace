﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    public bool canBePressed;
    public KeyCode keyToPress;
    public GameObject hitEffect, goodEffect, perfectEffect, missEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress)){
            if(canBePressed){
                gameObject.SetActive(false);

                // GameManager.instance.NoteHit();

                if (transform.position.y > -2.97){
                    Debug.Log("hit");
                    GameManager.instance.NormalHit();
                    Instantiate(hitEffect,transform.position, hitEffect.transform.rotation);
                // }else if(transform.position.y > 3.15){
                //     Debug.Log("Perfect");
                //     GameManager.instance.PerfectHit();
                //     Instantiate(perfectEffect,transform.position, perfectEffect.transform.rotation);
                }
                else{
                    Debug.Log("Perfect!");
                    GameManager.instance.PerfectHit();
                    Instantiate(perfectEffect,transform.position, perfectEffect.transform.rotation);
                }
            }
        }   
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Activator"){
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        if (gameObject.active){
            if(other.tag == "Activator"){
                canBePressed = false;
                GameManager.instance.NoteMissed();
                Instantiate(missEffect,transform.position, missEffect.transform.rotation);
            }
        }
    }
}

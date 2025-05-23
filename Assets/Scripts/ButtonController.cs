﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;
    
    public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //button ditekan
        if (Input.GetKeyDown(keyToPress)){
            theSR.sprite = pressedImage;
        }
        //button dilepas
        if(Input.GetKeyUp(keyToPress)){
            theSR.sprite = defaultImage;
        }
    }    
}

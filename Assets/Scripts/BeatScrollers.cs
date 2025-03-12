﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScrollers : MonoBehaviour
{

    public float beatTempo;
    public bool hasStarted;

    // public float Tempo;
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted){
            // if(Input.anyKeyDown){
            //     hasStarted = true;
            // }
        }else {
            transform.position -= new Vector3 (beatTempo *  Time.deltaTime, 0.0f,  0f);
            // 0.1f untuk ke kiri
        }
    }


}

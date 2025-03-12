using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCar : MonoBehaviour
{

    public float enemyTempo;

    public bool hasStarted;
    // Start is called before the first frame update
    void Start()
    {
        enemyTempo = enemyTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted){
            // if(Input.anyKeyDown){
            //     hasStarted = true;
            // }
        }else {
            transform.position += new Vector3 ( enemyTempo *  Time.deltaTime, 0.0f,  0f);
            // 0.1f untuk ke kiri
        }
    }
}

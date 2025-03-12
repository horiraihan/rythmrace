using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public static Countdown instance;
    public int countdownTime;
    public Text CountdownText;

    void Start()
    {
        instance = this;
        StartCoroutine(CountdownToStart());
    }

    void Update()
    {
        
    }

    public IEnumerator CountdownToStart() {
        while(countdownTime > 0) {
            CountdownText.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f); //hitung per 1 detik

            countdownTime--;
        }

        CountdownText.text = "GO";
        yield return new WaitForSeconds(1f);
        CountdownText.gameObject.SetActive(false);
    }

}

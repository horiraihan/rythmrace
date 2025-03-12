using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }

    public void Bantuan(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

    public void Menu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }

    public void Skip(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }

    public void QuitGame(){
        Debug.Log("Keluar"); 
        Application.Quit();
    }
}

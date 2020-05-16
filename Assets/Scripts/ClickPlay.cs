using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ClickPlay : MonoBehaviour
{
    public void BtnScene(string name)
    {
        SceneManager.LoadScene(name); 
    }

    public void QuitGame()
    {

        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Update()
    {
       if (Input.GetButtonDown("Jump"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Load the next scene from the index
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Load the next scene from the index
    }
}

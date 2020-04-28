using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("CharacterFirstPerson");
    }

    public void resetGame()
    {
        SceneManager.LoadScene("CharacterFirstPerson");
    }

    public void goMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    void onPause()
    {
        if (Input.GetButtonDown("Cancel"))
            SceneManager.LoadScene("PauseMenu");

    }

}

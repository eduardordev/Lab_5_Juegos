using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAndURLLoader : MonoBehaviour
{
    private PauseMenu m_PauseMenu;


    private void Awake ()
    {
        m_PauseMenu = GetComponentInChildren <PauseMenu> ();
    }


    public void SceneLoad()
	{
		//PauseMenu pauseMenu = (PauseMenu)FindObjectOfType(typeof(PauseMenu));
		m_PauseMenu.MenuOff ();
		SceneManager.LoadScene("PauseMenu");
	}



}


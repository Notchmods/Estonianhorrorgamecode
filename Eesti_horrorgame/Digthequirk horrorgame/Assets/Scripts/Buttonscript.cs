using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class Buttonscript : MonoBehaviour
{
    public bool game;
    public bool started;
    bool paused;
    public Transform[] pausemenu;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0f)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (Time.timeScale == 1f)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        //If the game is running then pause menu can be enabled
        if (game == true)
        {
            if (Input.GetKeyDown(KeyCode.P)|| Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0f;    
                pausemenu[0].gameObject.SetActive(true);
            }
        }

    }

    //Start game
    public void Startgame()
    {
        SceneManager.LoadScene(1);
    }

    //Quit game
    public void Exitgame()
    {
        Application.Quit();
    }

    //Switch scene to main menu
    public void loadmenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void unpaused()
    {
        Time.timeScale = 1f;
    }

    public void Startedgame()
    {
        Time.timeScale = 1f;
    }
}

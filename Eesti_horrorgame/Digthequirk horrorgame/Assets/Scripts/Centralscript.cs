using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Centralscript : MonoBehaviour
{
    public int difficulty;
    public bool ingame;
    public Transform[] Diggis;  
    // Start is called before the first frame update
    void Start()
    {
        if (ingame == true)
        {
            int difficulty2 = PlayerPrefs.GetInt("difficulty");
            difficulty = difficulty2;
            if (difficulty == 2)
            {
                Diggis[0].gameObject.SetActive(true);
                Diggis[1].gameObject.SetActive(true);
            }

            if (difficulty == 3)
            {
                Diggis[0].gameObject.SetActive(true);
                Diggis[1].gameObject.SetActive(true);
                Diggis[2].gameObject.SetActive(true);
                Diggis[3].gameObject.SetActive(true);
                Diggis[4].gameObject.SetActive(true);
                Diggis[5].gameObject.SetActive(true);
            }
        }

        if (difficulty == 1)
        {
            Debug.Log("Null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(ingame == true)
        {
            if(difficulty == 1)
            {
                if (Diggis[4].gameObject.activeInHierarchy == false && Diggis[5].gameObject.activeInHierarchy == false)
                {
                    SceneManager.LoadScene(2);
                }
            }
            if (difficulty == 2)
            {
                if (Diggis[0].gameObject.activeInHierarchy == false &&Diggis[1].gameObject.activeInHierarchy == false && Diggis[4].gameObject.activeInHierarchy == false && Diggis[5].gameObject.activeInHierarchy == false)
                {
                    SceneManager.LoadScene(2);
                }
            }
            if (difficulty == 2)
            {
                if (Diggis[0].gameObject.activeInHierarchy == false && Diggis[1].gameObject.activeInHierarchy == false && Diggis[2].gameObject.activeInHierarchy == false && Diggis[3].gameObject.activeInHierarchy == false && Diggis[4].gameObject.activeInHierarchy == false && Diggis[5].gameObject.activeInHierarchy == false)
                {
                    SceneManager.LoadScene(2); 
                }
            }
        }
    }

    public void Savesettingseasy()
    {
        PlayerPrefs.SetInt("difficulty", 1);
        PlayerPrefs.Save();
    }
    public void Savesettingsnnormal()
    {
        PlayerPrefs.SetInt("difficulty", 2);
        PlayerPrefs.Save();
    }

    public void Savesettingshard()
    {
        PlayerPrefs.SetInt("difficulty", 3);
        PlayerPrefs.Save();
    }
}

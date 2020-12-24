using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sprache : MonoBehaviour
{
    public Transform[] Messagesload;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Loadmessages());
    }

    public void Exitgamemainmenu()
    {
        SceneManager.LoadScene(0);  
    }

    IEnumerator Loadmessages()
    {
        yield return new WaitForSeconds(2f);
        Messagesload[0].gameObject.SetActive(true);
        yield return new WaitForSeconds(5f);
        Messagesload[1].gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        Messagesload[2].gameObject.SetActive(true);
        yield return new WaitForSeconds(8f);
        Messagesload[3].gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        Messagesload[4].gameObject.SetActive(true);
        yield return new WaitForSeconds(5f);
        Messagesload[5].gameObject.SetActive(true);
    }
}
